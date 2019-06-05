using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Electrician : IVisitor
    {
        public void VisitBuilding(Building building)
        {
           if (building.CheckElectricity())
            {
                Console.WriteLine($"В данном доме все в порядке");

                foreach (Floor fl in building.Floors)
                {
                    VisitFloor(fl);
                }
            }
        }

        public void VisitFloor(Floor floor)
        {
            if (floor.CheckElectricity())
            {
                Console.WriteLine($"На этаже {floor.Number} все в порядке");

                foreach (Room r in floor.Rooms)
                {
                    VisitRoom(r);
                }
            }
            else
            {
               Console.WriteLine($"На этаже { floor.Number} обнаружена неисправность");
            }
        }

        public void VisitRoom(Room room)
        {
            if (room.CheckElectricity())
            {
                Console.WriteLine($"В комнате № {room.Number} все в порядке");
            }
            else
            {
                Console.WriteLine($"В комнате № {room.Number} обнаружена неисправность");
            }
        }
    }
}
