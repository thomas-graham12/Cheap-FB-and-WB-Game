using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBounceTween : MonoBehaviour
{
    public LeanTweenType easeType;
    private void OnEnable()
    {
        LeanTween.moveY(gameObject, 2f, 0.6f).setLoopPingPong().setEase(easeType);
    }
}
