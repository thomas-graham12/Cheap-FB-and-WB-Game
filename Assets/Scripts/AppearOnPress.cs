using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearOnPress : MonoBehaviour
{
    public GameObject reAppear;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
            reAppear.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
            reAppear.SetActive(false);
    }
}
