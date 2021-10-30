using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class IngredientOnGround : Interractable
{
    public GameObject playerObject;
    public IngredientType ingredientType;

    private CinemachineImpulseSource cinemachineImpulseSource;
    public GameObject effect;

    public GameObject[] enable;
    
    private void Awake()
    {
        cinemachineImpulseSource = GetComponent<CinemachineImpulseSource>();
    }

    public override void OnInterract() {
        this.keyGuide.SetActive(false);
        effect.SetActive(true);

        Player player = playerObject.GetComponent<Player>();
        player.SetSelectedInterractable(null);
        
        RecipeManager.Instance.OnFind(ingredientType);

        CutsceneManager.Instance.StartCutscene(ingredientType.ToString());
        cinemachineImpulseSource.GenerateImpulse();

        foreach (GameObject g in enable) {
            g.SetActive(true);
        }
    }
}
