using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Room : IElement
    {
        public int Number { set; get; }

        public Room(int num)
        {
            Number = num;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitRoom(this);
        }
        public bool CheckElectricity()
        {
            Random rnd = new Random();
            int n = rnd.Next(10);
            System.Threading.Thread.Sleep(50);

            return (n < 6) ? true: false;
        }
    }


    public class Floor : IElement
    {
       public int Number { set; get; }
        public List<Room> Rooms { private set; get; } = new List<Room>();

        public Floor(int num)
        {
            Number = num;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitFloor(this);
        }

        public bool CheckElectricity()
        {
            Random rnd = new Random();
            int n = rnd.Next(10);
            System.Threading.Thread.Sleep(50);

            return (n < 6) ? true : false;
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
    }


    public class Building : IElement
    {
        public List<Floor> Floors { private set; get; } = new List<Floor>();
        public void Accept(IVisitor visitor)
        {
            visitor.VisitBuilding(this);
        }
        public bool CheckElectricity()
        {
            Random rnd = new Random();
            int n = rnd.Next(10);
            System.Threading.Thread.Sleep(50);

            return (n < 6) ? true : false;
        }

        public void AddFloor(Floor floor)
        {
            Floors.Add(floor);
        }

    }
}
