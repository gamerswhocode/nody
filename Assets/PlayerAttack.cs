using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    private int moleCounter = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mole") 
            && (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack")))
        {
            Destroy(collision.gameObject);
            --moleCounter;
        }

        if (moleCounter == 0)
        {
            SceneManager.LoadScene("VictoryScene");
        }
    }
}
