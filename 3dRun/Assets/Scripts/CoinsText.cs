using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsText : MonoBehaviour
{
    public Text txtcoin;
    void Update()
    {
        txtcoin.text =":"+ StaticVariables.coins.ToString();
    }
}
