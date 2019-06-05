using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Room room1 = new Room(101);
            Room room2 = new Room(102);
            Room room3 = new Room(103);
            Room room4 = new Room(104);
            Room room5 = new Room(105);

            Floor floor1 = new Floor(1);
            floor1.AddRoom(room1);
            floor1.AddRoom(room2);
            floor1.AddRoom(room3);
            floor1.AddRoom(room4);
            floor1.AddRoom(room5);

            Building building = new Building();
            building.AddFloor(floor1);

            IVisitor visitor = new Electrician();
            visitor.VisitBuilding(building);


            Console.ReadKey();
        }
    }
}
