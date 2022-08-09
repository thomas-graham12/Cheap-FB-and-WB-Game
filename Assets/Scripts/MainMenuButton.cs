using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void StartLevel()
    {
        SceneManager.LoadScene("Level 1");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level 1");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
