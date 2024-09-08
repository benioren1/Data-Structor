using BalancedBinaryTree;
using FirstWeekInData;
//using static System.Runtime.InteropServices.JavaScript.JSType;
//using System.Text.Json;
//Stack stack1 = new Stack();

//AVLTree tree = new AVLTree();

//// Example Insertions
//tree.Insert(10);
//tree.Insert(20);
//tree.Insert(30);
//tree.Insert(40);
//tree.Insert(50);
//tree.Insert(25);

//Console.WriteLine("In-order traversal of the AVL tree:");
//tree.PrintAll();

//// Example Deletions
//tree.Delete(10);

//Console.WriteLine("In-order traversal after deletion:");
//tree.PrintAll();


//stack1.push(1);
//stack1.push(2);
//stack1.push(3);
//stack1.push(4);
//stack1.Pop();
//Console.WriteLine(stack1.peek()); 

//Queue1 queue1 = new Queue1();
//queue1.Equeue(1);
//queue1.Equeue(2);
//queue1.Equeue(3);
//queue1.Equeue(4);
//queue1.Equeue(5);
//queue1.Dequeue();
//queue1.Dequeue();
//queue1.Equeue(8);
//Console.WriteLine(queue1.peek());
//Console.Write(Recurtion1.isPalindrome("abcdcba"));
//Console.Write(Recurtion1.decimalToBinary(30));
//BinaryTree binaryTree = new BinaryTree();
//binaryTree.Insert(20);
//binaryTree.Insert(3);
//binaryTree.Insert(7);
//binaryTree.Insert(34);
//binaryTree.Delete(7);
//binaryTree.PrintTree();
//Console.WriteLine(binaryTree.Find(3));
//Console.WriteLine(binaryTree.Find(30));
//Console.WriteLine(binaryTree.FindMin());
//Console.WriteLine(binaryTree.FindMax());

//binaryTree.PrintAll();

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3 };
        char[][] chars = new char[3][];

        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr1.Length; j++)
            {
                chars[i][i] = '_';
            }



        }
    }
    public bool Win(char[][] board)
    {
        if (board.Length != 3 || board[0].Length != 3)
        {
            throw new ArgumentException("The board must be 3x3.");
        }

        bool CheckLine(char c1, char c2, char c3)
        {
            return c1 == c2 && c2 == c3 && c1 != ' ';
        }

        switch (true)
        {
            // Check all rows
            case var _ when CheckLine(board[0][0], board[0][1], board[0][2]):
            case var _ when CheckLine(board[1][0], board[1][1], board[1][2]):
            case var _ when CheckLine(board[2][0], board[2][1], board[2][2]):
                return true;

            // Check all columns
            case var _ when CheckLine(board[0][0], board[1][0], board[2][0]):
            case var _ when CheckLine(board[0][1], board[1][1], board[2][1]):
            case var _ when CheckLine(board[0][2], board[1][2], board[2][2]):
                return true;

            // Check diagonals
            case var _ when CheckLine(board[0][0], board[1][1], board[2][2]):
            case var _ when CheckLine(board[0][2], board[1][1], board[2][0]):
                return true;

            default:
                return false;
        }
    }
}

















//public class Program
//{
//    public static object JsonConvert { get; private set; }
//    public static object JsonFileReader { get; private set; }

//    public static void Main(string[] args)
//    {
//        string filePath = @"C:\firstweek in data\FirstWeekInData\json1.json";


//        string jsonString = File.ReadAllText(filePath);


//        var data = JsonSerializer.Deserialize<Dictionary<string, Json>>(jsonString);


//        var trees = new Dictionary<string, BinaryTree>();


//        foreach (var kvp in data)
//        {
//            BinaryTree tree = new BinaryTree();
//            tree.Name = kvp.Key;

//            foreach (var number in kvp.Value.list)
//            {
//                tree.Insert(number); 
//            }

//            trees[kvp.Key] = tree; 
//        }

//        foreach (var kvp in trees)
//        {
//            Console.WriteLine($"Tree for key: {kvp.Key}");
//            Console.WriteLine($"Name: {kvp.Value.Name}");
//            Console.WriteLine($"Min: {kvp.Value.FindMin()}");
//            Console.WriteLine($"Max: {kvp.Value.FindMax()}");
//            Console.WriteLine();
//        }


//    }
//}