using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetZone : MonoBehaviour
{
    public Transform playertransform;
    CoinMove coinmovescript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MagnetZone")
        {
            playertransform = GameObject.FindGameObjectWithTag("Player").transform;
            coinmovescript = gameObject.GetComponent<CoinMove>();
            coinmovescript.enabled = true;
        }
    }
}
