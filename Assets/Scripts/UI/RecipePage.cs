using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipePage : MonoBehaviour
{
    public GameObject recipePageUI;

    public void OnRecipePageOpen() {
        recipePageUI.SetActive(true);
    }

    public void OnRecipePageClose() {
        recipePageUI.SetActive(false);
    }

    public void OnRecipePageTrigger() {
        recipePageUI.SetActive(!recipePageUI.activeSelf);
    }
}
