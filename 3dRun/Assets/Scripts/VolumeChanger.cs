using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    public AudioSource charaudio;
    public AudioSource cameraaudio;
    public Scrollbar volumescroll;
    // Start is called before the first frame update
    void Start()
    {
        charaudio.volume = volumescroll.value;
        cameraaudio.volume = volumescroll.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Change()
    {
        charaudio.volume = volumescroll.value;
        cameraaudio.volume = volumescroll.value;
    }
}
