using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    public GameObject coindetectorobj;
    private Animator charanim;
    private Rigidbody charrb;
    public AudioSource charaudio;
    public AudioClip coin;
    public AudioClip buff;
    public AudioClip wall;
    // Start is called before the first frame update
    void Start()
    {
        coindetectorobj = GameObject.FindGameObjectWithTag("MagnetZone");
        coindetectorobj.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            charanim = gameObject.GetComponent<Animator>();
            charanim.SetTrigger("Loose");
            charaudio.clip = wall;
            charaudio.Play();
            StaticVariables.isLoose = true;
            StaticVariables.isSlow = false;
            Time.timeScale = 1f;
            StartCoroutine(Loose());
        }
        if (collision.gameObject.tag == "Coin")
        {
            StaticVariables.coins++;
            StaticVariables.allcoins++;
            PlayerPrefs.SetInt("AllCoins", StaticVariables.allcoins);
            charaudio.clip=coin;
            charaudio.Play();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "SlowBuff")
        {
            StaticVariables.slowmotionbuffs++;
            charaudio.clip = buff;
            charaudio.Play();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Magnet")
        {
            charaudio.clip = buff;
            charaudio.Play();
            StartCoroutine(ActivateMagnet());
            Destroy(collision.gameObject);
        }
    }
    private IEnumerator ActivateMagnet()
    {
        coindetectorobj.SetActive(true);
        yield return new WaitForSeconds(10);
        coindetectorobj.SetActive(false);
    }
    private IEnumerator Loose()
    {
        yield return new WaitForSeconds(3);
        StaticVariables.isLoose = false;
        SceneManager.LoadScene(0);
    }
}
