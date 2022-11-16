using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAppbret : MonoBehaviour
{
    public void AppToOpenbret(GameObject app)
    {
        app.SetActive(true);
    }

    public void AppToClosebret(GameObject app)
    {
        app.SetActive(false);
    }
}
