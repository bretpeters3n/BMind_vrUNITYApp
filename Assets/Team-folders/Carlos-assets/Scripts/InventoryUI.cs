using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI crystalCount;
    // Start is called before the first frame update
    void Start()
    {
        crystalCount = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCrystalCount(PlayerInventory playerInventory)
    {
        crystalCount.text = playerInventory.NumberOfCrystals.ToString();

    }
}
