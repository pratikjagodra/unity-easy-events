
namespace PJ.EasyEvents
{
    public interface IEventListener { }

    public interface IEventListener<T> : IEventListener where T : EventBase
    {
        public void OnTrigger(T eventData);
    }
}
