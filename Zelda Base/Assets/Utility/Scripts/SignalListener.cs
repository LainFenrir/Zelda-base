using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SignalListener : MonoBehaviour {

    public List<SignalAndResponse> signalAndResponses = new List<SignalAndResponse>();

    private void OnEnable() {

        if (signalAndResponses.Count >= 1) {
            foreach (SignalAndResponse item in signalAndResponses) {
                item.signal.RegisterListener(this);
            }
        }

    }
    private void OnDisable() {
        if (signalAndResponses.Count >= 1) {
            foreach (SignalAndResponse item in signalAndResponses) {
                item.signal.UnregisterListener(this);
            }
        }
    }

    [ContextMenu("Raise Events")]
    public void OnSignalRaised(Signal passedSignal) {

        for (int i = signalAndResponses.Count - 1; i >= 0; i--) {

            if (passedSignal == signalAndResponses[i].signal) {
                signalAndResponses[i].OnSignalRaised();
            }
        }

    }
}