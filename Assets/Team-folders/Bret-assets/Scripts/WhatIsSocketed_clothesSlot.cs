using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WhatIsSocketed_clothesSlot : MonoBehaviour
{
    List<IXRSelectInteractable> itemInSocket;
    public bool isClothes;

    public void CheckClothesSocket()
    {
        if (gameObject.GetComponent<XRSocketInteractor>().hasSelection)
        {
            itemInSocket = gameObject.GetComponent<XRSocketInteractor>().interactablesSelected;
            Debug.Log("Socket holds: " + itemInSocket[0].transform.name);
            if ( itemInSocket[0].transform.name == "Bento" || itemInSocket[0].transform.name == "wallet" || itemInSocket[0].transform.name == "id-card-design" || itemInSocket[0].transform.name == "clothes-pile" )
            {
                isClothes = true;
            }
            else
            {
                isClothes = false;
            }
        }
        else
        {
            Debug.Log("Socket is Empty");
        }
    }
}