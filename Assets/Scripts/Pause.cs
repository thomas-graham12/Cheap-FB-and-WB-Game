using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject gameUI;
    public GameObject pauseUI;

    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused == true)
            {
                isPaused = false;
            }
            else
            {
                isPaused = true;
            }

            if (isPaused == true)
            {
                PauseGame();
            }
            else
            {

                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        gameUI.SetActive(false);
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        gameUI.SetActive(true);
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
