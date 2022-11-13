using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenApp : MonoBehaviour
{
    public void AppToOpen(GameObject app)
    {
        app.SetActive(true);
    }

    public void AppToClose(GameObject app)
    {
        app.SetActive(false);
    }
}
