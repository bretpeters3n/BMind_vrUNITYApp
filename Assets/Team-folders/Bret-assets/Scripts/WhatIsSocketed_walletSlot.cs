using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WhatIsSocketed_walletSlot : MonoBehaviour
{
    List<IXRSelectInteractable> itemInSocket;
    public bool isWallet;

    public void CheckWalletSocket()
    {
        if (gameObject.GetComponent<XRSocketInteractor>().hasSelection)
        {
            itemInSocket = gameObject.GetComponent<XRSocketInteractor>().interactablesSelected;
            Debug.Log("Socket holds: " + itemInSocket[0].transform.name);
            if (itemInSocket[0].transform.name == "Bento" || itemInSocket[0].transform.name == "wallet" || itemInSocket[0].transform.name == "id-card-design" || itemInSocket[0].transform.name == "clothes-pile")
            {
                isWallet = true;
            }
            else
            {
                isWallet = false;
            }
        }
        else
        {
            Debug.Log("Socket is Empty");
        }
    }
}
