using System;
using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.Builder
{
    public class CountingMazeBuilder : MazeBuilder
    {
        public CountingMazeBuilder()
        {
            doors = rooms = 0;
        }

        public override void BuildMaze()
        {
            throw new NotImplementedException();
        }

        public override void BuildRoom(int number)
        {
            base.BuildRoom(number);
            rooms++;
        }

        public override void BuildDoor(int room1, int room2)
        {
            base.BuildDoor(room1, room2);
            doors++;
        }

        public override IMaze GetMaze()
        {
            throw new NotImplementedException();
        }

        public int GetRoomCounts()
        {
            return rooms;
        }
        public int GetDoorCounts()
        {
            return doors;
        }

        private int doors;

        private int rooms;
    }
}