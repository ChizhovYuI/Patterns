namespace Patterns.BehavioralPatterns.Interfaces
{
    public interface IMazeFactory
    {
        IMaze MakeMaze();

        IWall MakeWall();

        IRoom MakeRoom(int number);

        IDoor MakeDoor(IRoom room1, IRoom room2);
    }
}

