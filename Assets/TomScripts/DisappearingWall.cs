using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingWall : MonoBehaviour
{
    public GameObject wall;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            Destroy(wall);
        }
    }
}
