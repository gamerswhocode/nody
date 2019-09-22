using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLifeSystem : MonoBehaviour
{
    public bool IsInvincible { get; private set; } = false;
    public float invincibilityTimeInSeconds = 2f;
    public float TotalHp { get; set; } = 5;
    public LifeCountManager PlayerLifeCountManager;
    private float currentHp;

    public void Start()
    {
        currentHp = TotalHp;        
    }

    public void ApplyDamage()
    {
        StartCoroutine(InvencibilityTime());
        ReceiveDamage();
    }

    private IEnumerator InvencibilityTime()
    {
        //Debug.Log("StartInvencibilityTime");
        IsInvincible = true;
        yield return new WaitForSeconds(invincibilityTimeInSeconds);
        IsInvincible = false;
        //Debug.Log("EndInvencibilityTime");
    }

    public void ReceiveDamage()
    {
        if (--currentHp < 0f)
        {
            currentHp = 0f;
        }

        Func<bool> isPlayerDefeated = () => (currentHp == 0f);
        PlayerLifeCountManager.DecreaseLife();
        if (isPlayerDefeated())
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("GameOverScene");
        }
        else
        {
            Debug.Log($"Current Hp: { currentHp }");
        }
    }


}
