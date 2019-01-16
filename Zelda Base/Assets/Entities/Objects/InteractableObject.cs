using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableObject : MonoBehaviour {

    public bool isBreakable;
    public bool isPickable;
    protected bool playerInRange;
    public Transform itemPos;
    protected bool isHeld;
   
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    protected void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            playerInRange = true;
        }
    }

    protected void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            playerInRange = false;
        }
    }

    protected void Pickup(Transform objectTransform) {
        if (isPickable) {
            objectTransform.position = itemPos.position;
        }
    }

    protected void Break() {
        if (isBreakable) {

        }
    }
}