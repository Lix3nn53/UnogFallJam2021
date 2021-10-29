using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientOnGround : Interractable
{
    public IngredientType ingredientType;
    public Recipe recipe;
    
    public override void OnInterract() {
        recipe.OnFind(ingredientType);
        CutsceneManager.Instance.StartCutscene(ingredientType.ToString());
    }
}
