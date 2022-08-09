using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPrompts : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1f;
    }
}
