using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlatform : MonoBehaviour
{
    public GameObject staticPlatform;
    public string nameTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(nameTag))
            staticPlatform.SetActive(true);
    }
}
