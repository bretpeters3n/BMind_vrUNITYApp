using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CheckBackpackSlots : MonoBehaviour
{
    public GameObject backpackCapacitySlots;
    public GameObject challengeSuccess;
    public GameObject challengeFail;
    public GameObject tryAgain;

    public GameObject food;
    public GameObject wallet;
    public GameObject id;
    public GameObject clothes;

    public WhatIsSocketed_foodSlot whatIsSocketed_foodSlot;
    public WhatIsSocketed_walletSlot whatIsSocketed_walletSlot;
    public WhatIsSocketed_IDSlot whatIsSocketed_IDSlot;
    public WhatIsSocketed_clothesSlot whatIsSocketed_clothesSlot;

    public StarScriptBret starScriptBret;

    public void CheckAllSocket()
    {
        //public GameObject challengeFail;

        backpackCapacitySlots = GameObject.Find("Canvas-backpackCapSlots");
        challengeSuccess = GameObject.Find("Canvas-challengeSuccess");
        tryAgain = GameObject.Find("TryAgainParent");

        food = GameObject.Find("Bento");
        wallet = GameObject.Find("wallet");
        id = GameObject.Find("id-card-design");
        clothes = GameObject.Find("clothes-pile");

        if ((whatIsSocketed_foodSlot.isFood == true) && (whatIsSocketed_walletSlot.isWallet == true) && (whatIsSocketed_IDSlot.isID == true) && (whatIsSocketed_clothesSlot.isClothes == true))
        {
            Debug.Log("Challenge complete");
            backpackCapacitySlots.SetActive(false);

            food.SetActive(false);
            wallet.SetActive(false);
            id.SetActive(false);
            clothes.SetActive(false);

            //challengeSuccess.SetActive(true);
            //audioChallengeComplete.Play();
            //audioSource1.Play();
            //starScriptBret.CreateStarScriptBret();
        }
        else
        {
            Debug.Log("Challenge incomplete");
            //audioTryAgain.Play();
            //audioSource2.Play();
        }
    }
}
