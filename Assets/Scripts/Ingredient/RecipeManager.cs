using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RecipeManager : MonoBehaviour
{
    public static RecipeManager Instance;

    [SerializeField]private PlayerAnimationController playerAnimationController;

    // RECIPE
    [SerializeField]private GameObject recipeButtonUI;
    [SerializeField]private GameObject recipeOnGround;

    // HAT
    [SerializeField]private GameObject hatGround;
    [SerializeField]private bool hatFound = false;

    // CANDY
    [SerializeField]private GameObject candyGround;
    [SerializeField]private bool candyFound = false;

    // Bat
    [SerializeField]private GameObject batGround;
    [SerializeField]private bool batFound = false;

    // Skull
    [SerializeField]private GameObject skullGround;
    [SerializeField]private bool skullFound = false;

    // Wool
    [SerializeField]private GameObject woolGround;
    [SerializeField]private bool woolFound = false;

    // Candle
    [SerializeField]private GameObject candleGround;
    [SerializeField]private bool candleFound = false;

    // Candle
    [SerializeField]private GameObject mamaFood;

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
	}

    public void OnFind(IngredientType type) {
        if (type.Equals(IngredientType.RECIPE)) {
            AudioManager.Instance.Play("find");
        
            StartCoroutine(OnRecipe());
        } else if (type.Equals(IngredientType.HAT)) {
            AudioManager.Instance.Play("find");
        
            StartCoroutine(OnHat());
        } else if (type.Equals(IngredientType.CANDY)) {
            AudioManager.Instance.Play("kapow");

            StartCoroutine(OnCandy());
        } else if (type.Equals(IngredientType.BAT)) {
            AudioManager.Instance.Play("kapow");

            StartCoroutine(OnBat());
        } else if (type.Equals(IngredientType.SKULL)) {
            AudioManager.Instance.Play("kapow");

            StartCoroutine(OnSkull());
        } else if (type.Equals(IngredientType.WOOL_BALL)) {
            AudioManager.Instance.Play("kapow");

            StartCoroutine(OnWoolBall());
        } else if (type.Equals(IngredientType.CANDLE)) {
            AudioManager.Instance.Play("kapow");

            StartCoroutine(OnCandle());
        }

        StartCoroutine(CheckMama());
    }

    IEnumerator OnRecipe() {
        yield return new WaitForSeconds(1.5f);

        recipeButtonUI.SetActive(true);
        recipeOnGround.SetActive(false);
    }

    IEnumerator OnHat() {
        yield return new WaitForSeconds(1.5f);

        hatFound = true;
        hatGround.SetActive(false);
        playerAnimationController.OnHatFind();
    }

    IEnumerator OnCandy() {
        yield return new WaitForSeconds(1.5f);

        candyFound = true;
        candyGround.SetActive(false);
    }

    IEnumerator OnSkull() {
        yield return new WaitForSeconds(1.5f);

        skullFound = true;
        skullGround.SetActive(false);
    }

    IEnumerator OnCandle() {
        yield return new WaitForSeconds(1.5f);

        candleFound = true;
        candleGround.SetActive(false);
    }

    IEnumerator OnBat() {
        yield return new WaitForSeconds(1.5f);

        batFound = true;
        batGround.SetActive(false);
    }

    IEnumerator OnWoolBall() {
        yield return new WaitForSeconds(1.5f);

        woolFound = true;
        woolGround.SetActive(false);
    }

    IEnumerator CheckMama() {
        yield return new WaitForSeconds(2f);

        if (hatFound && candyFound && skullFound && candleFound && batFound && woolFound) {
            mamaFood.SetActive(true);
        }
    }
}
