using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl_active_morceaux : MonoBehaviour
{
    public ctrl_morceaux morceaux;
    float HitTimer;
    public float timer;
    public float keepActivatedTimer = 5;
    public float keepActivatedTimerParticle = 8;
    public AudioClip son;
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
        if (currentKeepActivatedTimer < keepActivatedTimerParticle)
        {
            currentKeepActivatedTimer += Time.deltaTime;
            if (currentKeepActivatedTimer >= keepActivatedTimer)
            {
                morceaux.isActivated = false;
            }
            if (currentKeepActivatedTimer >= keepActivatedTimerParticle)
            {
                morceaux.gameObject.SetActive(false);
            }
        }
        else
        {
            timer = timer + Time.deltaTime;
            if (timer > HitTimer)
            {
                AudioSource.PlayClipAtPoint(son, morceaux.transform.position);
                timer = 0.0f;
                HitTimer = Random.Range(5, 10);
                currentKeepActivatedTimer = 0;
                morceaux.gameObject.SetActive(true);
                morceaux.isActivated = true;

            }
        }
    }
}
