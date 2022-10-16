using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy : MonoBehaviour
{
    public GameObject TrophyPrefab;

    public void CreateTrophy()
    
    {
        GameObject newTrophy = Instantiate(TrophyPrefab);  
           
    }
}
