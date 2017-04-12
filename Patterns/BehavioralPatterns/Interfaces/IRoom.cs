using System.Collections.Generic;
using Patterns.BehavioralPatterns.Domains;

namespace Patterns.BehavioralPatterns.Interfaces
{
    public interface IRoom : IMapSite
    {
        int Number { get; }

        IMapSite GetSide(Direction direction);

        void SetSide(Direction direction, IMapSite mapSite);

        IMapSite[] Sides { get; }
    }
}
