using Patterns.BehavioralPatterns.Domains;

namespace Patterns.BehavioralPatterns.Builder
{
    public class Result
    {
        public Result()
        {
            var mazeGame = new MazeGame();
            var standartMazeBuilder = new StandartMazeBuilder();
            var countingBuilder = new CountingMazeBuilder();

            var standartMaze = mazeGame.CreateMaze(standartMazeBuilder);

            var countingMaze = mazeGame.CreateMaze(countingBuilder);

            var roomCount = countingBuilder.GetRoomCounts();
            var doorCount = countingBuilder.GetDoorCounts();

            var complexMaze = mazeGame.CreateComplexMaze(standartMazeBuilder);
        }
    }
}