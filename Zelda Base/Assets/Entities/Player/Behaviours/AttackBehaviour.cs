using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehaviour : StateMachineBehaviour {
    public Signal attackSignal;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        attackSignal.sentBool = true;
        attackSignal.Raise();
    }
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

    }
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        attackSignal.sentBool = false;
        attackSignal.Raise();
    }
}