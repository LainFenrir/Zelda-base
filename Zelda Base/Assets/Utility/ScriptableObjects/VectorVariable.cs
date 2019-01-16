using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FloatVariable", menuName = "Variables/Vector Variable", order = 1)]
public class VectorVariable : ScriptableObject, ISerializationCallbackReceiver {
	public Vector2 value;
	public Vector2 defaultValue;

    public void OnAfterDeserialize()
    {
        value = defaultValue;
    }

    public void OnBeforeSerialize()
    {
        
    }
}
