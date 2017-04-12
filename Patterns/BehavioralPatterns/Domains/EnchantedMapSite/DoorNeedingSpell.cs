using Patterns.BehavioralPatterns.Domains.CommonMapSite;
using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.Domains.EnchantedMapSite
{
    public class DoorNeedingSpell : Door
    {
        public DoorNeedingSpell(IRoom room1, IRoom room2) : base(room1, room2) {}

        public override void Enter()
        {
            throw new System.NotImplementedException();
        }

        public override IRoom OtherSideFrom(IRoom room)
        {
            throw new System.NotImplementedException();
        }
    }
}
