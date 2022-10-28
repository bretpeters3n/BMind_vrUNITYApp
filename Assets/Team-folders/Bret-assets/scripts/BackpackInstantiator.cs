using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack_instantiator : MonoBehaviour
{
    public GameObject backpackPrefab;

    public void CreateBackpack()
    {
        GameObject newBackpack = Instantiate(backpackPrefab);
    }
}