using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystals : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();


        if (playerInventory != null)
        {
            playerInventory.CrystalCollected();
            gameObject.SetActive(false);

        }

    }
}
