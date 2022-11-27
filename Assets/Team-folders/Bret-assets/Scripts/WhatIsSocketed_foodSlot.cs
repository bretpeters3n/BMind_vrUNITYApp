using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WhatIsSocketed_foodSlot : MonoBehaviour
{
    List<IXRSelectInteractable> itemInSocket;
    public bool isFood;

    public void CheckFoodSocket()
    {
        if (gameObject.GetComponent<XRSocketInteractor>().hasSelection)
        {
            itemInSocket = gameObject.GetComponent<XRSocketInteractor>().interactablesSelected;
            Debug.Log("Socket holds: " + itemInSocket[0].transform.name);
            if (itemInSocket[0].transform.name == "Bento")
            {
                isFood = true;
            }
            else 
            {
                isFood = false;
            }
        }
        else
        {
            Debug.Log("Socket is Empty");
        }
    }
}