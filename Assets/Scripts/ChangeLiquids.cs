using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLiquids : MonoBehaviour
{
    public GameObject liquidOne;
    public GameObject liquidTwo;
    public string nameTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(nameTag))
        {
            liquidOne.SetActive(false);
            liquidTwo.SetActive(true);
        }
    }
}
