using System;
using Patterns.BehavioralPatterns.Domains.CommonMapSite;

namespace Patterns.BehavioralPatterns.Domains.BombedMapSite
{
    public class RoomWithBomb : Room
    {
        public RoomWithBomb(int number) : base(number) {}

        public override void Enter()
        {
            throw new NotImplementedException();
        }
    }
}