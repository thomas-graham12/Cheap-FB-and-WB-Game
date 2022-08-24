using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnPress : MonoBehaviour
{
    public GameObject disappear;
    public GameObject reAppear;
    public string nameTag;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(nameTag))
        {
            disappear.SetActive(false);
            reAppear.SetActive(true);
        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(nameTag))
        {
            disappear.SetActive(true);
            reAppear.SetActive(false);
        }
    }
}
