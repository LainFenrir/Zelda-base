using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : InteractableObject {

    public Signal pickupSignal;
    public Transform parentTransform;

    private Collider2D trigger;

    void Start() {
        trigger = GetComponent<Collider2D>();
    }

    void Update() {
        if (Input.GetButtonDown("Interact") && playerInRange) {
            Pickup(parentTransform);
            pickupSignal.Raise();
            this.enabled = false;

        }
    }

}