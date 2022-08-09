using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearOnPress : MonoBehaviour
{
    public GameObject reAppear;
    public GameObject disappear;
    public string nameTag;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(nameTag))
        {
            reAppear.SetActive(true);
            disappear.SetActive(false);
        }
            
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(nameTag))
        {
            reAppear.SetActive(false); ;
            disappear.SetActive(true);
        }
    }
}
