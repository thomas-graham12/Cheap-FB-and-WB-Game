using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SpikesReset : MonoBehaviour
{
    // public string nameTag;
    public TextMeshProUGUI deadScreen;
    public GameObject deadPanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            deadPanel.SetActive(true);
            deadScreen.text = "Oh no, Player 1 got deaded! Press the reset button to go again!";
            Time.timeScale = 0f;
        }
        if (other.CompareTag("Player2"))
        {
            deadPanel.SetActive(true);
            deadScreen.text = "Oh no, Player 2 got deaded! Press the reset button to go again!";
            Time.timeScale = 0f;
        }
    }
}
