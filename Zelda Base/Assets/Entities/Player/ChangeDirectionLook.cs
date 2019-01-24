using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirectionLook : MonoBehaviour {
    public VectorVariable lookAt;
    public Vector2 horizontalValue;
    public Vector2 verticalValue;

    void Start() {

    }

    void Update() {
        if (lookAt.value == Vector2.up || lookAt.value == new Vector2(1, 1) || lookAt.value == new Vector2(-1, 1)) {
            transform.localPosition = verticalValue;
        }
        if (lookAt.value == Vector2.down || lookAt.value == new Vector2(1, -1) || lookAt.value == new Vector2(-1, -1)) {
            transform.localPosition = verticalValue * -1;
        }
        if (lookAt.value == Vector2.left) {
            Vector2 left = new Vector2(horizontalValue.x * -1, horizontalValue.y);
            transform.localPosition = left;
        }
        if (lookAt.value == Vector2.right) {
            transform.localPosition = horizontalValue;
        }

    }
}