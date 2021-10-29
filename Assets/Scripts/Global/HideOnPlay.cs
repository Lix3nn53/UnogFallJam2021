using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnPlay : MonoBehaviour
{
    void Start()
    {
        if (!GameSettings.Instance.hideOnPlay) return;

        Renderer renderer = GetComponent<Renderer>();
        renderer.enabled = false;
    }
}
