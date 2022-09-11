using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShopSkins : MonoBehaviour
{
    public GameObject manskin;
    public GameObject womanskin;
    public GameObject womanbutton;
    public GameObject sold;
    // Start is called before the first frame update
    void Start()
    {
        StaticVariables.isWomanSold = PlayerPrefs.GetInt("WomanSkin");
        StaticVariables.skin = PlayerPrefs.GetInt("Skin");
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticVariables.isWomanSold == 0)
        {
            womanbutton.SetActive(false);
            sold.SetActive(false);
        }
        if (StaticVariables.isWomanSold == 1)
        {
            womanbutton.SetActive(true);
            sold.SetActive(true);
        }
        if (StaticVariables.skin == 0)
        {
            womanskin.SetActive(false);
            manskin.SetActive(true);
        }
        if (StaticVariables.skin == 1)
        {
            womanskin.SetActive(true);
            manskin.SetActive(false);
        }
    }
    public void BuyWoman()
    {
        if (StaticVariables.isWomanSold == 0 && StaticVariables.allcoins>100)
        {
            StaticVariables.isWomanSold = 1;
            StaticVariables.allcoins -= 100;
            PlayerPrefs.SetInt("AllCoins", StaticVariables.allcoins);
            PlayerPrefs.SetInt("WomanSkin", StaticVariables.isWomanSold);
        }
    }
    public void WearMan()
    {
        StaticVariables.skin = 0;
        PlayerPrefs.SetInt("Skin", StaticVariables.skin);
    }
    public void WearWoman()
    {
        StaticVariables.skin = 1;
        PlayerPrefs.SetInt("Skin", StaticVariables.skin);
    }
}
