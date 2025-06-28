namespace PJ.Easy.Events
{
    public interface IEventListener { }

    public interface IEventListener<T> : IEventListener where T : struct
    {
        public void OnTrigger(T eventData);
    }
}
