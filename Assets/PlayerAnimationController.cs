using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public Animator animator;

    private const string MOVING_STATE = "Moving";
    private const string IDLE_STATE = "Idle";
    // Update is called once per frame
    void Update()
    {
        float playerHorizontalAxisValue = Input.GetAxis("Horizontal");
        float playerVerticalAxisValue = Input.GetAxis("Vertical");

        Func<bool> isPlayerMoving = () => (playerHorizontalAxisValue != 0 || playerVerticalAxisValue != 0);

        string playerState = isPlayerMoving() ? MOVING_STATE : IDLE_STATE;
        animator.Play(playerState);
    }
}
