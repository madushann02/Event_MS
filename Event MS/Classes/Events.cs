namespace Event_MS.Classes
{
    internal class Events
    {
        // Property to store the event ID
        public string EventId { get; set; }

        // Property to store the event name
        public string EventName { get; set; }

        // Property to store the event type
        public string EventType { get; set; }

        // Constructor to initialize the event properties
        public Events(string eventId, string eventName, string eventType)
        {
            EventId = eventId;
            EventName = eventName;
            EventType = eventType;
        }
    }
}
