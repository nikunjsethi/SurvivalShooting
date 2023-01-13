using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : StateMachineBehaviour
{
    public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
        Debug.Log("Hit the player");
    }
}
