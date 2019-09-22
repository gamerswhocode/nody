using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopoAttack : MonoBehaviour
{
    public float attackRange = 1f;
    public Animator animator;

    private Transform player;
    private bool topoSpawned = false;


    private void Start()
    {
        player = GameObject.Find("Jugador").transform;
    }
    public void OnTopoSpawnComplete()
    {
        topoSpawned = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // Debug.Log("StartOnTriggerStay2D");
        // Debug.Log("StartOnTriggerStay2D");
        if (!topoSpawned) return;
        if (collision.gameObject.CompareTag("Player"))
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("TopoIdle"))
            {
                animator.Play("TopoAttack");
            }
        }
        //Debug.Log("EndOnTriggerStay2D");
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, attackRange);
    }
}
