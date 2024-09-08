using System;

namespace BalancedBinaryTree
{
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int Height { get; set; }

        public TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
            Height = 1;
        }
    }

    public class AVLTree
    {
        public TreeNode Root { get; set; }

        public AVLTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Root = Insert(Root, data);
        }

        private TreeNode Insert(TreeNode node, int data)
        {
            if (node == null)
            {
                return new TreeNode(data);
            }

            if (data < node.Data)
            {
                node.Left = Insert(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = Insert(node.Right, data);
            }
            else
            {
                // Duplicate data is not allowed in this tree.
                return node;
            }

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            int balance = GetBalance(node);

            // Left Left Case
            if (balance > 1 && data < node.Left.Data)
            {
                return RightRotate(node);
            }

            // Right Right Case
            if (balance < -1 && data > node.Right.Data)
            {
                return LeftRotate(node);
            }

            // Left Right Case
            if (balance > 1 && data > node.Left.Data)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left Case
            if (balance < -1 && data < node.Right.Data)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node;
        }

        private TreeNode LeftRotate(TreeNode z)
        {
            TreeNode y = z.Right;
            TreeNode T2 = y.Left;

            y.Left = z;
            z.Right = T2;

            z.Height = 1 + Math.Max(GetHeight(z.Left), GetHeight(z.Right));
            y.Height = 1 + Math.Max(GetHeight(y.Left), GetHeight(y.Right));

            return y;
        }

        private TreeNode RightRotate(TreeNode z)
        {
            TreeNode y = z.Left;
            TreeNode T3 = y.Right;

            y.Right = z;
            z.Left = T3;

            z.Height = 1 + Math.Max(GetHeight(z.Left), GetHeight(z.Right));
            y.Height = 1 + Math.Max(GetHeight(y.Left), GetHeight(y.Right));

            return y;
        }

        private int GetHeight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            return node.Height;
        }

        private int GetBalance(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            return GetHeight(node.Left) - GetHeight(node.Right);
        }

        public void Delete(int data)
        {
            Root = Delete(Root, data);
        }

        private TreeNode Delete(TreeNode root, int data)
        {
            if (root == null)
            {
                return null;
            }

            if (data < root.Data)
            {
                root.Left = Delete(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = Delete(root.Right, data);
            }
            else
            {
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                TreeNode temp = GetMinValueNode(root.Right);
                root.Data = temp.Data;
                root.Right = Delete(root.Right, temp.Data);
            }

            if (root == null)
            {
                return null;
            }

            root.Height = 1 + Math.Max(GetHeight(root.Left), GetHeight(root.Right));

            int balance = GetBalance(root);

            if (balance > 1 && GetBalance(root.Left) >= 0)
            {
                return RightRotate(root);
            }

            if (balance > 1 && GetBalance(root.Left) < 0)
            {
                root.Left = LeftRotate(root.Left);
                return RightRotate(root);
            }

            if (balance < -1 && GetBalance(root.Right) <= 0)
            {
                return LeftRotate(root);
            }

            if (balance < -1 && GetBalance(root.Right) > 0)
            {
                root.Right = RightRotate(root.Right);
                return LeftRotate(root);
            }

            return root;
        }

        private TreeNode GetMinValueNode(TreeNode node)
        {
            TreeNode current = node;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }

        public void PrintAll()
        {
            PrintAll(Root);
            Console.WriteLine();
        }

        private void PrintAll(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            PrintAll(node.Left);
            Console.Write(node.Data + " ");
            PrintAll(node.Right);
        }
    }

    
}
