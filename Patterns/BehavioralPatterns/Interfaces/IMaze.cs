using System.Collections.Generic;

namespace Patterns.BehavioralPatterns.Interfaces
{
    public interface IMaze
    {
        void AddRoom(IRoom room);

        IRoom GetRoom(int roomNumber);

        List<IRoom> Rooms { get; }
    }
}
