using System;
using System.Collections.Generic;

public enum EVENT
{
	MyEvent1,
	MyEvent2,
	PlayerChanged,

}; // ... Other events
public static class EventManager<T>
{
	// Stores the delegates that get called when an event is fired
	private static Dictionary<EVENT, Action<T>> eventTable
		= new Dictionary<EVENT, Action<T>>();

	// Adds a delegate to get called for a specific event
	public static void AddHandler(EVENT evnt, Action<T> action)
	{
		if (!eventTable.ContainsKey(evnt)) eventTable[evnt] = action;
		else eventTable[evnt] += action;
	}

	// Fires the event
	public static void Broadcast(EVENT evnt, T obj)
	{
		if (eventTable[evnt] != null)
		{
			eventTable[evnt].Invoke(obj);
		}
	}
	public static void RemoveHandler(EVENT evnt, Action<T> action)
	{
		if (eventTable[evnt] != null)
			eventTable[evnt] -= action;
		if (eventTable[evnt] == null)
			eventTable.Remove(evnt);
	}
}