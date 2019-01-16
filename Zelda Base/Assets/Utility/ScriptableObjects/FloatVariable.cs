using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FloatVariable", menuName = "Variables/Float Variable", order = 0)]
public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver {
	public float initialValue;
	[HideInInspector]
	public float runTimeValue;

	public void OnAfterDeserialize() {
		runTimeValue = initialValue;
	}

	public void OnBeforeSerialize() {

	}
}