using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class SignalAndResponse {
	
	public string name;
	public Signal signal;
	public UnityEvent response;
	public ResponseWithString responseForSentString;
	public ResponseWithInt responseForSentInt;
	public ResponseWithFloat responseForSentFloat;
	public ResponseWithBool responseForSentBool;
	
	public void OnSignalRaised() {
		
        if (response.GetPersistentEventCount() >= 1) 
        {
            response.Invoke();
        }

        // string
        if (responseForSentString.GetPersistentEventCount() >= 1)
        {
            responseForSentString.Invoke(signal.sentString);
        }

        // int
        if (responseForSentInt.GetPersistentEventCount() >= 1)
        {
            responseForSentInt.Invoke(signal.sentInt);
        }

        // float
        if (responseForSentFloat.GetPersistentEventCount() >= 1)
        {
            responseForSentFloat.Invoke(signal.sentFloat);
        }

        // bool
        if (responseForSentBool.GetPersistentEventCount() >= 1)
        {
            responseForSentBool.Invoke(signal.sentBool);
        }
	}
}

[System.Serializable]
public class ResponseWithString : UnityEvent<string>
{
}

[System.Serializable]
public class ResponseWithInt : UnityEvent<int>
{
}

[System.Serializable]
public class ResponseWithFloat : UnityEvent<float>
{
}

[System.Serializable]
public class ResponseWithBool : UnityEvent<bool>
{
}