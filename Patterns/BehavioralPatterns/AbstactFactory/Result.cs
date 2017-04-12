using Patterns.BehavioralPatterns.Domains;

namespace Patterns.BehavioralPatterns.AbstactFactory
{
    public class Result
    {
        public Result()
        {
            var commonMaze = new MazeGame().CreateMaze(new MazeFactory());

            var enchantedMaze = new MazeGame().CreateMaze(new EnchantedMazeFactory());

            var bombedMaze = new MazeGame().CreateMaze(new BombedMazeFactory());
        }
    }
}
