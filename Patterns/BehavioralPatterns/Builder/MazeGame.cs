using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.Builder
{
    public class MazeGame
    {
        public IMaze CreateMaze(IMazeBuilder mazeBuilder)
        {
            mazeBuilder.BuildMaze();

            mazeBuilder.BuildRoom(1);
            mazeBuilder.BuildRoom(2);
            mazeBuilder.BuildDoor(1, 2);

            return mazeBuilder.GetMaze();
        }

        public IMaze CreateComplexMaze(IMazeBuilder mazeBuilder)
        {
            mazeBuilder.BuildMaze();

            for (var i = 0; i < 1000; i++)
            {
                mazeBuilder.BuildRoom(i);
            }
            // ...

            return mazeBuilder.GetMaze();
        }
    }
}
