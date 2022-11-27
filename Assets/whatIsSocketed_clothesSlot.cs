using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class whatIsSocketed_clothesSlot : MonoBehaviour
{
    List<IXRSelectInteractable> itemInSocket;

    public void CheckClothesSocket()
    {
        if (gameObject.GetComponent<XRSocketInteractor>().hasSelection)
        {
            itemInSocket = gameObject.GetComponent<XRSocketInteractor>().interactablesSelected;
            Debug.Log("Socket holds: " + itemInSocket[0].transform.name);
        }
        else
        {
            Debug.Log("Socket is Empty");
        }
    }
}
