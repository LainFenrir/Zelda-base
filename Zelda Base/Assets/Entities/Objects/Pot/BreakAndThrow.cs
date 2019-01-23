using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakAndThrow : InteractableObject {

    private Animator anim;
    private Rigidbody2D rb;
    private bool isThrown;
    public Transform throwDistance;
    public GameObject throwSpot;
    public Signal throwSignal;
    public Signal enableScript;
    private bool hit;

    void Start() {
        GetReferences();
    }

    void Update() {
        if (isHeld) {
            Move();
            if ((Input.GetButtonDown("Interact") || Input.GetButtonDown("Attack")) && !isThrown) {
                throwSpot.transform.position = throwDistance.position;
                RaiseThrowSignal();
                RaiseEnableScript();
            }
        }
        if (isThrown) {
            ThrowItem();
        }

    }

    /********* Actions*************/
    private void Move() {
        transform.position = itemPos.position;
    }

    private void ThrowItem() {
        if (!hit) {
            iTween.MoveUpdate(this.gameObject, throwSpot.transform.position, 0.3f);
            if (CheckDistance()) {
                if (isBreakable) {
                    Break(anim);
                }
            }
        }
    }
    private bool CheckDistance() {
        float position = throwSpot.transform.position.magnitude - transform.position.magnitude;
        if (position < 0.2) {
            return true;
        }
        else {
            return false;
        }
    }

    /***********Signals **************/
    public void CollisionHit() {
        hit = true;
        if (isBreakable) {
            Break(anim);
        }
    }

    public void SetIsHeld(bool value) {
        isHeld = value;
    }

    private void RaiseThrowSignal() {
        isThrown = true;
        isHeld = false;
        throwSignal.Raise();
    }

    private void RaiseEnableScript() {
        enableScript.sentBool = true;
        enableScript.Raise();
    }

    /*********Utility ***********/
    private void GetReferences() {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
}