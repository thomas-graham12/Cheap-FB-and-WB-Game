using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPrompts : MonoBehaviour
{
    public string currentLevel;
    public void RestartLevel()
    {
        SceneManager.LoadScene(currentLevel);
        Time.timeScale = 1f;
    }
}
