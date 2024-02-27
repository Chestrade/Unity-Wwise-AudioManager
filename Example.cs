using UnityEngine;

public class Example : MonoBehaviour
{
	//Decalre the AudioManager variable. 
	private AudioManager audioManager;
	
	void Start()
	{
		//Reference to the AudioManager instance. 
		audioManager = AudioManager.Instance;
		
		
		//This is an example of how you can call an event from any script.
		//In this case, it will post the event corresponding to the string "event name". 
		//It will produce a warning in the console if no event is associated with that string.
		audioManager.PostEvent("event name");
	}
}