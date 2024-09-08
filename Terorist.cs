using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekInData
{
    public class Terorist
    {
        public static Dictionary<string, Location> mydict = new Dictionary<string, Location>();
        public static void addterorist(string name, int x ,int y)
        {
            mydict.Add(name, new Location(x, y));
        }
    }


    public class Location
    { 
    
    public int x {  get; set; }
    public int y { get; set; }
        public Location(int x, int y)

        { 
        this.x = x;
            this.y = y;
        }
    
    }
}
