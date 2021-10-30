using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class IngredientOnGround : Interractable
{
    public IngredientType ingredientType;

    private CinemachineImpulseSource cinemachineImpulseSource;
    public GameObject effect;
    
    private void Awake()
    {
        cinemachineImpulseSource = GetComponent<CinemachineImpulseSource>();
    }

    public override void OnInterract() {
        this.keyGuide.SetActive(false);
        effect.SetActive(true);
        RecipeManager.Instance.OnFind(ingredientType);

        CutsceneManager.Instance.StartCutscene(ingredientType.ToString());
        cinemachineImpulseSource.GenerateImpulse();
    }
}
