using Patterns.BehavioralPatterns.Domains.BombedMapSite;
using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.FactoryMethod
{
    public class BombedMazeGame : MazeGame
    {
        protected override IRoom MakeRoom(int n)
        {
            return new RoomWithBomb(n);
        }

        protected override IWall MakeWall()
        {
            return new BomedWall();
        }
    }
}