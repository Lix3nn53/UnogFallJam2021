using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    public static CutsceneManager Instance;
    [SerializeField]private Animator cameraAnimator;
    [SerializeField]private CharacterController2D characterController;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
        }
    }

    public void StartCutscene(string sceneName) {
        cameraAnimator.SetBool(sceneName, true);

        characterController.DisableInput = true;
        Rigidbody2D rigidbody = characterController.gameObject.GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector3();
        PlayerAnimationController animationController = characterController.gameObject.GetComponent<PlayerAnimationController>();
		animationController.OnMove(0f);

        StartCoroutine(EndCutscene(sceneName, 2f));
    }

    IEnumerator EndCutscene(string sceneName, float delay) {
        yield return new WaitForSeconds(delay);

        cameraAnimator.SetBool(sceneName, false);
        characterController.DisableInput = false;
    }
}
