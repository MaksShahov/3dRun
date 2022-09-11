using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && StaticVariables.slowmotionbuffs > 0)
        {
            StaticVariables.slowmotionbuffs--;
            Time.timeScale = 0.25f;
            StaticVariables.charspeed = 10;
            StaticVariables.isSlow = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 1f;
            StaticVariables.charspeed = 5;
            StaticVariables.isSlow = false;
        }
    }
}
