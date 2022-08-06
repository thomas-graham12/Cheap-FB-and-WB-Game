using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public GameObject gameObjectOne;
    public GameObject gameObjectTwo;
    // Update is called once per frame
    void Update()
    {
        if (gameObjectOne == null && gameObjectTwo == null)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
