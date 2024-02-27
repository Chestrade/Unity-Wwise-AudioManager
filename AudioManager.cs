using UnityEngine;
using System;

public class AudioManager : Monobehaviour 
{
	public static AudioManager Instance {get; private set; }
	public WwiseEvent[] events;
	
	void Awake()
	{
		//Singleton pattern to ensure only one instance of the AudioManager is present.
		if(Instance == null)
		{
			Instance == this;
		}
		else
		{
			Destroy(gameObject);
		}
	}

	//Call this function to post the desired event.
	public void PostEvent(string name)
	{
		//Search for the event in the WwiseEvent array corresponding to the name string.
		WwiseEvent foundEvent = Array.Find(events, wwiseEvent => wwiseEvent.name == name);
		
		if(foundEvent != null)
		{
			
			AK.Wwise.Event eventToPost = foundEvent.AkEvent;
			GameObject gameObjectToPost = foundEvent.eventGameObject;
			
			//Post the matching event.
			eventToPost.Post(gameObjectToPost);
		}
		else
		{
			Debug.LogWarning("WwiseEvent with name " + name + " not found");
		}
	}
}