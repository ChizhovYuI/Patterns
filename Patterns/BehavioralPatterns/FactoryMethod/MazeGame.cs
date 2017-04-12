using System;
using Patterns.BehavioralPatterns.Domains;
using Patterns.BehavioralPatterns.Domains.CommonMapSite;
using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.FactoryMethod
{
    public class MazeGame
    {
        public IMaze CreateMaze()
        {
            var maze = MakeMaze();

            var r1 = MakeRoom(1);
            var r2 = MakeRoom(2);
            var door = MakeDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.East, MakeWall());
            r1.SetSide(Direction.East, door);
            r1.SetSide(Direction.South, MakeWall());
            r1.SetSide(Direction.West, MakeWall());

            r2.SetSide(Direction.East, MakeWall());
            r2.SetSide(Direction.East, MakeWall());
            r2.SetSide(Direction.South, MakeWall());
            r2.SetSide(Direction.West, door);

            return maze;
        }

        protected virtual IMaze MakeMaze()
        {
            return new Maze();
        }

        protected virtual IRoom MakeRoom(int n)
        {
            return new Room(n);
        }

        protected virtual IWall MakeWall()
        {
            return new Wall();
        }

        protected virtual IDoor MakeDoor(IRoom room1, IRoom room2)
        {
            return new Door(room1, room2);
        }
    }
}