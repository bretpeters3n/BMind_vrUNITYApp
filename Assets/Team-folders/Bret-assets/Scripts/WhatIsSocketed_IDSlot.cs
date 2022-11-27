using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WhatIsSocketed_IDSlot : MonoBehaviour
{
    List<IXRSelectInteractable> itemInSocket;
    public bool isID;

    public void CheckIDSocket()
    {
        if (gameObject.GetComponent<XRSocketInteractor>().hasSelection)
        {
            itemInSocket = gameObject.GetComponent<XRSocketInteractor>().interactablesSelected;
            Debug.Log("Socket holds: " + itemInSocket[0].transform.name);
            if (itemInSocket[0].transform.name == "id-card-design")
            {
                isID = true;
            }
            else
            {
                isID = false;
            }
        }
        else
        {
            Debug.Log("Socket is Empty");
        }
    }
}
