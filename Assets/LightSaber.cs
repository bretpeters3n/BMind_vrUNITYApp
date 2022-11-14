using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaber : MonoBehaviour
{
    public Animator LightSaberAnimator;
   public void TurnOnLightSaber()
    {
        LightSaberAnimator.SetTrigger("TurnLightSaberOn");
        LightSaberAnimator.ResetTrigger("TurnLightSaberOff");
    }

    public void TurnLightSaberOff()
    {
        LightSaberAnimator.SetTrigger("TurnLightSaberOff");
        LightSaberAnimator.ResetTrigger("TurnLightSaberOn");
    }
}


