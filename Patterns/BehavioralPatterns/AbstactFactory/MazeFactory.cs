using Patterns.BehavioralPatterns.Domains;
using Patterns.BehavioralPatterns.Domains.CommonMapSite;
using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.AbstactFactory
{
    public class MazeFactory : IMazeFactory
    {
        public virtual IMaze MakeMaze()
        {
            return new Maze();
        }

        public virtual IWall MakeWall()
        {
            return new Wall();
        }

        public virtual IRoom MakeRoom(int number)
        {
            return new Room(number);
        }

        public virtual IDoor MakeDoor(IRoom room1, IRoom room2)
        {
            return new Door(room1, room2);
        }
    }
}