using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllCoinsText : MonoBehaviour
{
    public Text txtallcoins;
    private void Start()
    {
        StaticVariables.allcoins = PlayerPrefs.GetInt("AllCoins");
    }
    void Update()
    {
        txtallcoins.text = ":Хуй" + StaticVariables.allcoins.ToString();
    }
}
