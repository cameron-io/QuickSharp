using System;

namespace Lib.Events;

public class EventPublisher
{
    public delegate void EventHandler(object source, EventHandlerArgs args);

    public event EventHandler? EventCreated;

    public void EventSource(int a)
    {
        OnEventCreated(a);
    }

    protected virtual void OnEventCreated(int a)
    {
        EventCreated?.Invoke(this, new EventHandlerArgs(a));
    }
}