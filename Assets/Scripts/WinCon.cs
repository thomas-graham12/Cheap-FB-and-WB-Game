using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCon : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;

    void Update()
    {
        if (playerOne == null && playerTwo == null)
        {
            SceneManager.LoadScene("Win Scene");
        }
    }
}
