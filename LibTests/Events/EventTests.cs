using Lib.Events;

namespace LibTests.Events;

[TestClass]
public class EventTests
{
    [TestMethod]
    public void PubSubTest()
    {
        var eventPublisher = new EventPublisher();
        var eventSubscriber = new EventSubscriber();
        eventPublisher.EventCreated += eventSubscriber.OnEventCreated;
        eventPublisher.EventSource(3);
        eventPublisher.EventSource(6);

        Assert.AreEqual(9, eventSubscriber.GetScore());
    }
}
