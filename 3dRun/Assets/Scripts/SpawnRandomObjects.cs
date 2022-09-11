using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomObjects : MonoBehaviour
{
    public GameObject ventwall;
    public GameObject wall;
    public GameObject coin;
    public GameObject slowbuffs;
    public GameObject magnet;
    public float time;
    private float transpos=-1;
    public int type=0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(time);
        time = Random.Range(0.4f, 0.75f);
        type = Random.Range(1, 16);
        transpos = Random.Range(0,3);
        if (transpos == 0)
        {
            gameObject.transform.position = new Vector3(-3.8f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (transpos == 1)
        {
            gameObject.transform.position = new Vector3(-2.5f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (transpos == 2)
        {
            gameObject.transform.position = new Vector3(-1f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (type == 1 || type==2 || type==3 || type==9 || type==10 || type==11 || type == 12)
        {
            Instantiate(wall, gameObject.transform.position, Quaternion.identity);
        }
        if (type == 4 || type==5 || type==13 || type==14)
        {
            Instantiate(coin, gameObject.transform.position, Quaternion.identity);
        }
        if (type == 6)
        {
            Instantiate(slowbuffs, gameObject.transform.position, Quaternion.identity);
        }
        if (type == 7)
        {
            Instantiate(magnet, gameObject.transform.position, Quaternion.identity);
        }
        if (type == 8 || type==15)
        {
            Instantiate(ventwall, gameObject.transform.position, Quaternion.identity);
        }
        StartCoroutine(Spawn());
    }
}
