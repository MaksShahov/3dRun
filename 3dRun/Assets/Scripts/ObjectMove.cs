using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Run());
    }
    public IEnumerator Run()
    {
        if (StaticVariables.isLoose == false)
        {
            yield return new WaitForSeconds(0.02f);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - StaticVariables.speed);
            StartCoroutine(Run());
        }
    }
}
