using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadSign : InteractableObject {

    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public VectorVariable playerLookAt;
    public VectorVariable facingDirection;
    public Signal dialogSignal;

    void Start() {

    }
    //TODO: adicionar o sistema de dialogo e melhorar o codigo
    void Update() {
        if (Input.GetButtonDown("Interact") && playerInRange) {
            if (playerLookAt.value == facingDirection.value) {
                if (dialogBox.activeInHierarchy) {
                    dialogSignal.sentBool = false;
                    dialogSignal.Raise();
                    dialogBox.SetActive(false);
                }
                else {
                    dialogSignal.sentBool = true;
                    dialogSignal.Raise();
                    dialogBox.SetActive(true);
                    dialogText.text = dialog;
                }
            }
        }
    }

}