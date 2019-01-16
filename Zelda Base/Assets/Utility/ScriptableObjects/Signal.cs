using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Signal", menuName = "Signal", order = 1)]
public class Signal : ScriptableObject
{
    public string sentString;
    public int sentInt;
    public float sentFloat;
    public bool sentBool;

   private List<SignalListener> listeners = new List<SignalListener>();

	public void Raise() {
		for (int i = listeners.Count - 1; i >= 0; i--) {
			listeners[i].OnSignalRaised(this);
		}
	}

	public void RegisterListener(SignalListener listener){
		listeners.Add(listener);
	}

	public void UnregisterListener(SignalListener listener){
		listeners.Remove(listener);
	}
}
