using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverRestart : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnStartGameButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
