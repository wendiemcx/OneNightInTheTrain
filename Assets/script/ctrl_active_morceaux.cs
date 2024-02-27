using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl_active_morceaux : MonoBehaviour
{
    public GameObject morceaux;
    float HitTimer;
    public float timer;
    public float keepActivatedTimer = 1;

    public float currentKeepActivatedTimer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        HitTimer = Random.Range(5, 10);
        currentKeepActivatedTimer = keepActivatedTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentKeepActivatedTimer < keepActivatedTimer)
        {
            currentKeepActivatedTimer += Time.deltaTime;
            if(currentKeepActivatedTimer >= keepActivatedTimer)
            {
                morceaux.SetActive(false);
            }
        }
        else
        {
            timer = timer + Time.deltaTime;
            if (timer > HitTimer)
            {
                timer = 0.0f;
                HitTimer = Random.Range(5, 10);
                currentKeepActivatedTimer = 0;
                morceaux.SetActive(true);

            }
        }
    }
}
