namespace Patterns.BehavioralPatterns.Interfaces
{
    public interface IDoor : IMapSite
    {
        IRoom OtherSideFrom(IRoom room);

        IRoom Room1 { get; }

        IRoom Room2 { get; }

        bool IsOpen { get; set; }
    }
}
