namespace Patterns.BehavioralPatterns.Interfaces
{
    public interface IMazeBuilder
    {
        void BuildMaze();

        void BuildRoom(int room);

        void BuildDoor(int room1, int room2);

        IMaze GetMaze();
    }
}