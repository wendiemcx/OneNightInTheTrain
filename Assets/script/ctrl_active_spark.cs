using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl_active_spark : MonoBehaviour
{
    public float timer;
    public GameObject sparks;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer > 5.0f)
        {
            sparks.SetActive(true);
        }

        if (timer >6.0f)
        {
            sparks.SetActive(false);
            timer = 1.0f;

        }
    }
}
