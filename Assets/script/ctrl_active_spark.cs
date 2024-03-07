using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using UnityEngine;

public class ctrl_active_spark : MonoBehaviour
{
    public float timer;
    public GameObject sparks;
    public GameObject eclair;
    public float timer2;
    public AudioSource son;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        son = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer > 5.0f)
        {
            sparks.SetActive(true);
            if (son.isPlaying == false)
            {
                son.Play(0);
            }
        }

        if (timer >6.0f)
        {
            sparks.SetActive(false);
            timer = 1.0f;
        }


    }
}
