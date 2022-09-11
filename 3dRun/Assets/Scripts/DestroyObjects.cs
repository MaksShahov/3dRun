using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Die());
    }

    public IEnumerator Die()
    {
        yield return new WaitForSeconds(StaticVariables.destroytime);
        if (StaticVariables.isLoose == false)
        {
            Destroy(gameObject);
        }
    }
}
