using System;

namespace Lib.Events;

public class EventSubscriber
{
    private int _score = 0;

    public void OnEventCreated(object source, EventHandlerArgs args)
    {
        _score += args.NewScore;
    }

    public int GetScore()
    {
        return _score;
    }
}
