using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public bool Reload = false;
    private Animator charanim;
    public Animator logoanim;
    public Animator coinsanim;
    public Animator playanim;
    public Animator shopanim;
    public Animator settingsanim;
    public Animator shopwindowanim;
    public Animator settingswindowanim;
    public Animator allcoinsanim;
    public Button playbutton;
    public Button shopbutton;
    public Button settingsbutton;

    private float screen;
    private void Start()
    {
        screen = Screen.width;
    }
    private void Update()
    {
        if(StaticVariables.isLoose == true)
        {
            FinishGame();
        }
        int i = 0;
        while (i < Input.touchCount)
        {
            if (Reload == true)
            {
                if (Input.GetTouch(i).position.x > screen / 2)
                {
                    Movement(1f);
                }

                if (Input.GetTouch(i).position.x < screen / 2)
                {
                    Movement(-1f);
                }
            }
            ++i;
 
        }
    }
    void Movement(float line)
    {
            gameObject.transform.Translate(Vector3.right* line*Time.deltaTime*StaticVariables.charspeed);
            if (gameObject.transform.position.x < -4f)
            {
                gameObject.transform.position = new Vector3(-4f, gameObject.transform.position.y, gameObject.transform.position.z);
            }
            if (gameObject.transform.position.x > -1)
            {
                gameObject.transform.position = new Vector3(-1f, gameObject.transform.position.y, gameObject.transform.position.z);
            }
    }
    public IEnumerator AddSpeed()
    {
        if (StaticVariables.speed < 0.6)
        {
            yield return new WaitForSeconds(30f);
            StaticVariables.speed = StaticVariables.speed + 0.05f;
            StaticVariables.destroytime=StaticVariables.destroytime-2;
            StartCoroutine(AddSpeed());
        }
    }
    public void StartGame()
    {
        charanim = gameObject.GetComponent<Animator>();
        charanim.SetTrigger("Run");
        playanim.SetTrigger("Play");
        shopanim.SetTrigger("Play");
        coinsanim.SetTrigger("Play");
        logoanim.SetTrigger("Play");
        allcoinsanim.SetTrigger("Play");
        settingsanim.SetTrigger("Play");
        StaticVariables. speed = 0.15f;
        StartCoroutine(AddSpeed());
        StaticVariables.charspeed = 5;
        StaticVariables.coins = 0;
        StaticVariables.destroytime = 35;
        StaticVariables.slowmotionbuffs = 0;
        StaticVariables.isSlow = false;
        Reload = true;
    }
    public void ShopOpen()
    {
        shopwindowanim.SetTrigger("Play");
        shopbutton.enabled = false;
        playbutton.enabled = false;
        settingsbutton.enabled = false;
    }
    public void ShopClose()
    {
        shopwindowanim.SetTrigger("PlayReverse");
        shopbutton.enabled = true;
        playbutton.enabled = true;
        settingsbutton.enabled = true;
    }
    public void SettingsOpen()
    {
        settingswindowanim.SetTrigger("Play");
        shopbutton.enabled = false;
        playbutton.enabled = false;
        settingsbutton.enabled = false;
    }
    public void SettingsClose()
    {
        settingswindowanim.SetTrigger("PlayReverse");
        shopbutton.enabled = true;
        playbutton.enabled = true;
        settingsbutton.enabled = true;
    }
    public void FinishGame()
    {
        Reload = false;
    }
}
