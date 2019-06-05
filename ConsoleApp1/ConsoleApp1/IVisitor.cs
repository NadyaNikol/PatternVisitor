namespace ConsoleApp1
{
    public interface IVisitor
    {
        void VisitRoom(Room room);
        void VisitFloor(Floor floor);
        void VisitBuilding(Building building);
    }
}