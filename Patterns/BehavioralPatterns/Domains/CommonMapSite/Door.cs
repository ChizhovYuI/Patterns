using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.Domains.CommonMapSite
{
    public class Door : IDoor
    {
        public Door(IRoom room1, IRoom room2)
        {
            Room1 = room1;
            Room2 = room2;
        }

        public IRoom Room1 { get; }

        public IRoom Room2 { get; }

        public bool IsOpen { get; set; }

        public virtual void Enter()
        {
            throw new System.NotImplementedException();
        }

        public virtual IRoom OtherSideFrom(IRoom room)
        {
            throw new System.NotImplementedException();
        }
    }
}
