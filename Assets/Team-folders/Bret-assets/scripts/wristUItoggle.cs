using UnityEngine;
using UnityEngine.UI;

public class wristUItoggle : MonoBehaviour
{
    public GameObject wristUI;

    public bool wristUIIsEnabled;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        wristUIIsEnabled = false;
        wristUI.SetActive(wristUIIsEnabled);
    }

    private void TurnOnAndOff()
    {
        wristUIIsEnabled ^= true;
        wristUI.SetActive(wristUIIsEnabled);
    }
}