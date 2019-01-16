using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehaviour : StateMachineBehaviour {
    public Signal holdItemSignal;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        animator.SetBool("isHoldingItem", true);
        holdItemSignal.sentBool = true;
        holdItemSignal.Raise();
    }

}