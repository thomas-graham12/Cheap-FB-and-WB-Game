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
}
