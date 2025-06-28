namespace PJ.Easy.Events
{
    public interface IEventListener { }

    public interface IEventListener<T> : IEventListener where T : EventBase
    {
        public void OnTrigger(T eventData);
    }
}
