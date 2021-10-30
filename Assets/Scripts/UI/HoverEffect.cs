using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverEffect : MonoBehaviour
{
    public float angle = -30f;
    public float scale = 1.2f;
    public void OnHover() {
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        transform.localScale = new Vector3(scale, scale, 1f);
    }
    
    public void OnHoverExit() {
        transform.rotation = Quaternion.Euler(Vector3.forward * 0);
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
