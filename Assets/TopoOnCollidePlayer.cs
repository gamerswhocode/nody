using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class TopoOnCollidePlayer : MonoBehaviour
{
    public Animator animator;
    private PlayerLifeSystem playerLifeSystem;
    public float invencibilityTimeInSeconds = 2f;
    private bool canAttackPlayer = true;

    private void Start()
    {
        playerLifeSystem = GameObject.Find("Jugador").GetComponent<PlayerLifeSystem>();
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        Func<bool> canTopoAttackPlayer = () => (!playerLifeSystem.IsInvincible
            && collision.gameObject.CompareTag("Player")
            && animator.GetCurrentAnimatorStateInfo(0).IsName("TopoAttack"));

        if (canTopoAttackPlayer())
        {
            playerLifeSystem.ApplyDamage();
            Debug.Log("Ouch");

        }
    }
}
