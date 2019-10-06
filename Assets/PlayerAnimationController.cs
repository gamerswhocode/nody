using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public Animator animator;

    private const string MOVING_STATE = "Moving";
    private const string IDLE_STATE = "Idle";
    private const string ATTACK_STATE = "Attack";
    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            return;
        }

        float playerHorizontalAxisValue = Input.GetAxis("Horizontal");
        float playerVerticalAxisValue = Input.GetAxis("Vertical");

        Func<bool> isPlayerMoving = () => (playerHorizontalAxisValue != 0 || playerVerticalAxisValue != 0);

        string playerState = "";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerState = ATTACK_STATE;
        }
        else if (isPlayerMoving())
        {
            playerState = MOVING_STATE;
        }
        else
        {
            playerState = IDLE_STATE;
        }      
        
        animator.Play(playerState);
    }
}
