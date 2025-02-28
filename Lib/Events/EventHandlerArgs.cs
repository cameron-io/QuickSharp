using System;

namespace Lib.Events;

public class EventHandlerArgs(int score) : EventArgs
{
    public int NewScore { get; set; } = score;
}
