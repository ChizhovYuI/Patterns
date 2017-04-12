using Patterns.BehavioralPatterns.Domains.CommonMapSite;

namespace Patterns.BehavioralPatterns.Domains.EnchantedMapSite
{
    public class EnchantedRoom : Room
    {
        public EnchantedRoom(int number) :base(number) {}
        
        public override void Enter()
        {
            throw new System.NotImplementedException();
        }
    }
}
