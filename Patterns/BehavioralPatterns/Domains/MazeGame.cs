using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.Domains
{
    public class MazeGame
    {
        public IMaze CreateMaze(IMazeFactory factory)
        {
            var maze = factory.MakeMaze();
            var r1 = factory.MakeRoom(0);
            var r2 = factory.MakeRoom(1);
            var door = factory.MakeDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);
            r1.SetSide(Direction.North, factory.MakeWall());
            r1.SetSide(Direction.East, door);
            r1.SetSide(Direction.South, factory.MakeWall());
            r1.SetSide(Direction.West, factory.MakeWall());

            r2.SetSide(Direction.North, factory.MakeWall());
            r2.SetSide(Direction.East, factory.MakeWall());
            r2.SetSide(Direction.South, factory.MakeWall());
            r2.SetSide(Direction.West, door);

            return maze;
        }
    }
}
