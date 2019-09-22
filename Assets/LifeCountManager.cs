using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCountManager : MonoBehaviour
{    
    int currentLife = 4;
    private const int TOTAL_LIFE = 4;

    public void DecreaseLife()
    {
        if (currentLife >= 0)
        {
            transform.GetChild(currentLife).gameObject.SetActive(false);
            --currentLife;
        }
    }
    public void IncreaseLife()
    {
        if (currentLife + 1 < TOTAL_LIFE)
        {
            transform.GetChild(++currentLife).gameObject.SetActive(true);
        }
    }
}
