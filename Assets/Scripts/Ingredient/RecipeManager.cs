using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RecipeManager : MonoBehaviour
{
    public static RecipeManager Instance;
    [SerializeField]private BoolVariable hatFound;
    [SerializeField]private BoolVariable sugarFound;

    [SerializeField]private PlayerAnimationController playerAnimationController;

    private void Awake()
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
        
		hatFound.SetValue(false);
		sugarFound.SetValue(false);
	}

    public void OnFind(IngredientType type) {
        if (type.Equals(IngredientType.HAT)) {
            hatFound.SetValue(true);

            playerAnimationController.OnHatFind();
        }
    }
}
