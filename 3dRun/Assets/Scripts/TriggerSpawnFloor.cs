using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawnFloor : MonoBehaviour
{
    public GameObject spawnerfloor;
    public GameObject floor;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(floor, spawnerfloor.transform);
            gameObject.transform.position= new Vector3(gameObject.transform.position.x,gameObject.transform.position.y, spawnerfloor.transform.position.z);
        }
    }
}
