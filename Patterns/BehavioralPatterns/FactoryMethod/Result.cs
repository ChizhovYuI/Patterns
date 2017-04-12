using System.Runtime.InteropServices;

namespace Patterns.BehavioralPatterns.FactoryMethod
{
    public class Result
    {
        public Result()
        {
            var commonMaze = new MazeGame().CreateMaze();
            var bombedMaze = new BombedMazeGame().CreateMaze();
            var enchantedMazeGame = new EnchantedMazeGame().CreateMaze();
        }
    }
}