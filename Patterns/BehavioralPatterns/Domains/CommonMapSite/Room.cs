using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.Domains.CommonMapSite
{
    public class Room : IRoom
    {
        public Room(int number)
        {
            Number = number;
        }

        public int Number { get; }

        public IMapSite[] Sides { get; } = new IMapSite[4];

        public virtual void Enter()
        {
            throw new System.NotImplementedException();
        }

        public virtual IMapSite GetSide(Direction direction)
        {
            return Sides[(int)direction];
        }

        public virtual void SetSide(Direction direction, IMapSite mapSite)
        {
            Sides[(int)direction] = mapSite;
        }
    }
}
