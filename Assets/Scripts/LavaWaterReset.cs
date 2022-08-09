using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LavaWaterReset : MonoBehaviour
{
    public string nameTag;
    public TextMeshProUGUI deadText;
    public GameObject deadPanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(nameTag))
        {
            deadText.text = "Uh oh, someone has deaded! GG go next";
            deadPanel.SetActive(true);
        }
    }
}
