using System.Collections.Generic;
using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.Domains
{
    public class Maze : IMaze
    {
        public List<IRoom> Rooms { get; } = new List<IRoom>();

        public void AddRoom(IRoom room)
        {
            Rooms.Add(room);
        }

        public IRoom GetRoom(int roomNumber)
        {
            return Rooms[roomNumber];
        }
    }
}
