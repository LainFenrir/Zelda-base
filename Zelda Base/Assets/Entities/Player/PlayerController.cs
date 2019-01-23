using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public FloatVariable speed;
    public float maxHP;
    public FloatVariable currentHP;
    public float dashForce;

    public bool isDialoguing;
    public bool isAttacking;
    public bool isHoldingItem;

    public VectorVariable LookingAtDirection;
    private Vector3 direction;

    private Animator anim;
    private Rigidbody2D rb;

    void Start() {
        GetReferences();

    }

    void Update() {
        HandleInput();
    }

    /*************** Inputs and Checks *******************************/
    private void HandleInput() {
        direction = Vector3.zero;
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        if (!isDialoguing) {
            HandleDirection();
            HandleButtonPress();
        }
    }

    private void HandleDirection() {
        if (direction != Vector3.zero) {
            UpdateDirection();
            CheckToMove();
        }
        else {
            anim.SetBool("isMoving", false);
        }

    }

    private void CheckToMove() {
        if (!isAttacking) {
            anim.SetBool("isMoving", true);
            Move();
        }
    }

    private void HandleButtonPress() {
        if (Input.GetButtonDown("Dash")) {
            StartCoroutine(Dash());
        }
        if (Input.GetButtonDown("Attack")) {
            anim.SetTrigger("Attack");
        }
    }
    /*********************** Player Movement *************************/
    private void UpdateDirection() {
        LookingAtDirection.value = direction;
        anim.SetFloat("MoveX", direction.x);
        anim.SetFloat("MoveY", direction.y);
    }

    private void Move() {
        direction.Normalize();
        rb.MovePosition(transform.position + direction * speed.runTimeValue * Time.deltaTime);
    }

    private IEnumerator Dash() {
        rb.AddForce(LookingAtDirection.value * dashForce, ForceMode2D.Impulse);
        yield return new WaitForSeconds(0.2f);
        rb.velocity = Vector2.zero;

    }
    /*********************** Signal Actions *************************/
    public void SetIsDialoguing(bool value) {
        anim.SetBool("isDialoguing", value);
        isDialoguing = value;
    }

    public void SetIsAttacking(bool value) {
        isAttacking = value;
    }

    public void PickupItem() {
        anim.SetTrigger("Pickup");
    }

    public void SetIsHoldingItem(bool value) {
        isHoldingItem = value;
    }

    public void SetThrowItem() {
        anim.SetBool("isHoldingItem",false);
        isHoldingItem = false;
        if (!Input.GetButtonDown("Attack")) {
            anim.SetTrigger("Throw");
        }
    }
    /********************Utilities *************************************/
    private void GetReferences() {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

}