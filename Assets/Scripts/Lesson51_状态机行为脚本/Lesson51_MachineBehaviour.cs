using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson51_MachineBehaviour : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(stateInfo.IsName("Idle"))
        Debug.Log("OnStateIdleEnter");
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(stateInfo.IsName("Idle"))
        Debug.Log("OnStateIdleExit");
    }
}
