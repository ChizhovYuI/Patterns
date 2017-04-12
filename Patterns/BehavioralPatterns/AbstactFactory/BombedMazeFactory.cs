using Patterns.BehavioralPatterns.Domains.BombedMapSite;
using Patterns.BehavioralPatterns.Domains.EnchantedMapSite;
using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.AbstactFactory
{
    public class BombedMazeFactory : MazeFactory
    {
        public override IWall MakeWall()
        {
            return new BomedWall();
        }

        public override IDoor MakeDoor(IRoom room1, IRoom room2)
        {
            return new DoorNeedingSpell(room1, room2);
        }
    }
}
