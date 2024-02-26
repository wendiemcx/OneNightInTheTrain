using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl_active_morceaux : MonoBehaviour
{
    public GameObject morceaux;
    public float HitTimer;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        morceaux.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer > HitTimer )
        {
            timer = 0.0f;
            HitTimer = Random.Range(10, 20);
            morceaux.SetActive(true);
        }
    }
}
