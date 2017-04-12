using Patterns.BehavioralPatterns.Domains.EnchantedMapSite;
using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.AbstactFactory
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public override IRoom MakeRoom(int number)
        {
            return new EnchantedRoom(number, CastSpell());
        }

        public override IDoor MakeDoor(IRoom room1, IRoom room2)
        {
            return new DoorNeedingSpell(room1, room2);
        }

        private static Spell CastSpell()
        {
            return new Spell();
        }
    }
}