using Patterns.BehavioralPatterns.Interfaces;

namespace Patterns.BehavioralPatterns.Builder
{
    public abstract class MazeBuilder : IMazeBuilder
    {
        public virtual void BuildMaze() {}

        public virtual void BuildRoom(int number) {}

        public virtual void BuildDoor(int room1, int room2) {}

        public virtual IMaze GetMaze()
        {
            return null;
        }
    }
}