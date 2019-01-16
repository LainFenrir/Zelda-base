using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : InteractableObject {

    private Animator anim;
    private Rigidbody2D rb;

   
    void Start() {
        GetReferences();
    }

    void Update() {
        if (isHeld) {
            Move();
        }
    }

   

    private void Move() {
        transform.position = itemPos.position;
    }

    private void GetReferences() {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetIsHeld(bool value){
        isHeld = value;
    }
}