using Patterns.BehavioralPatterns.Domains.EnchantedMapSite;
using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.FactoryMethod
{
    public class EnchantedMazeGame : MazeGame
    {
        protected override IRoom MakeRoom(int n)
        {
            return new EnchantedRoom(n, CastSpell());
        }

        protected override IDoor MakeDoor(IRoom room1, IRoom room2)
        {
            return new DoorNeedingSpell(room1, room2);
        }

        private static Spell CastSpell()
        {
            return new Spell();
        }
    }
}