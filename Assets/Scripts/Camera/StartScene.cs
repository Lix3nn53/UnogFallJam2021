using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    [SerializeField]Sprite[] sprites;

    [SerializeField]CharacterController2D controller2D;
    SpriteRenderer sRenderer;

// Start is called before the first frame update
    void Awake()
    {
        sRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


    // Start is called before the first frame update
    void Start()
    {
        controller2D.DisableInput = true;
        StartCoroutine(cycleSprites());
    }

    IEnumerator cycleSprites() {
		foreach (Sprite s in sprites) {
            AudioManager.Instance.Play("extra");
            sRenderer.sprite = s;

            yield return new WaitForSeconds(3f);
        }

        controller2D.DisableInput = false;
        gameObject.SetActive(false);
	}
}
