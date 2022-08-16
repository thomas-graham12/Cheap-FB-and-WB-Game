using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDestroy : MonoBehaviour
{

    private void Update()
    {
        DestroyAfterTime();
    }

    void DestroyAfterTime()
    {
        Destroy(gameObject, 5);
    }
}
