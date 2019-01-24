using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : InteractableObject {
    public bool needKey;
    public VectorVariable playerLookAt;
    public VectorVariable facingDirection;
    private Animator anim;

    void Start() {
        GetReferences();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Interact") && playerInRange) {
            if (playerLookAt.value == facingDirection.value) {
                Open();
            }
        }
    }

    private void Open() {
        anim.SetTrigger("Open");
    }

    /*********Utility ***********/
    private void GetReferences() {
        anim = GetComponentInParent<Animator>();
    }
}