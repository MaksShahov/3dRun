using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    MagnetZone magnetscript;
    // Start is called before the first frame update
    void Start()
    {
        magnetscript = gameObject.GetComponent<MagnetZone>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, magnetscript.playertransform.position,7*Time.deltaTime);
    }
}
