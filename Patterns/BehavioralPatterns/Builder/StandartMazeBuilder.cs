using System;
using Patterns.BehavioralPatterns.Domains;
using Patterns.BehavioralPatterns.Domains.CommonMapSite;
using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.Builder
{
    public class StandartMazeBuilder : MazeBuilder
    {
        public override void BuildMaze()
        {
            currentMaze = new Maze();
        }

        public override void BuildRoom(int number)
        {
            if (currentMaze.GetRoom(number) == null)
            {
                var room = new Room(number);

                currentMaze.AddRoom(room);

                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.West, new Wall());
                room.SetSide(Direction.South, new Wall());
            }
        }

        public override void BuildDoor(int room1, int room2)
        {
            var r1 = currentMaze.GetRoom(room1);
            var r2 = currentMaze.GetRoom(room2);
            var door = new Door(r1, r2);

            r1.SetSide(CommonWall(r1, r2), door);
            r1.SetSide(CommonWall(r2, r1), door);
        }
        
        public override IMaze GetMaze()
        {
            return currentMaze;
        }

        private static Direction CommonWall(IRoom room1, IRoom room2)
        {
            throw new NotImplementedException();
        }

        private IMaze currentMaze;
    }
}