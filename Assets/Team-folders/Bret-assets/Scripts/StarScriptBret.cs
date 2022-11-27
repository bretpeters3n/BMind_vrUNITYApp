using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScriptBret : MonoBehaviour
{
    public GameObject StarScriptPrefab;

    public void CreateStarScript()
    {
        GameObject newStar = Instantiate(StarScriptPrefab);
    }
}
