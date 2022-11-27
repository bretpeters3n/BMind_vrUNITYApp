using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipGameIntro : MonoBehaviour
{
    public Animator GameIntroAnimator;

    public void SkipIntro()
    {
        //Debug.Log("Clicked Skip Intro");
        GameIntroAnimator.SetTrigger("Skip Game Intro");
    }
}
