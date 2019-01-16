using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BoolVariable", menuName = "Variables/Bool Variable", order = 2)]
public class BoolVariable : ScriptableObject, ISerializationCallbackReceiver {
   public bool defaultValue;
   public bool runTimeValue;

   public void OnAfterDeserialize() {
      runTimeValue = defaultValue;
   }

   public void OnBeforeSerialize() {

   }
}