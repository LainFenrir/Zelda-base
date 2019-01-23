using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColision : MonoBehaviour {
    public Signal isColliding;
    private Collider2D trigger;

    private void OnEnable() {
        trigger = GetComponent<Collider2D>();
    }
    void Start() {

    }

    void Update() {

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (!other.isTrigger && this.enabled && !other.CompareTag("Player")) {
            isColliding.Raise();
        }
    }
}