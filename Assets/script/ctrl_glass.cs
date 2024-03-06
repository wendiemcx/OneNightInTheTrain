using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ctrl_glass : MonoBehaviour
{
    public GameObject hache_affiche;
    public int destruction;
    public GameObject porte;
    public GameObject baton;
    public GameObject fer;
    public GameObject hache;

    public float timer_anim_hache;
    public bool timer_flag;
    // Start is called before the first frame update
    void Start()
    {
        porte.GetComponent<Animator>().enabled = false;
        timer_anim_hache = 0;
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "perso")
        {
            if (hache_affiche.activeSelf)
            {
                baton.SetActive(true);
                fer.SetActive(true);

                if (Input.GetButtonDown("Fire1"))
                {

                   timer_flag = true;
                    hache.GetComponent<Animator>().SetTrigger("tapptrig");

                }

                if (timer_flag == true)
                {
                    Debug.Log("déclanche le timer");
                    timer_anim_hache += Time.deltaTime; // on déclanche le timer
                }

                if (timer_anim_hache > 0.5f)
                {
                    destruction = destruction - 1;
                    timer_anim_hache = 0.0f;
                    timer_flag = false;

                    if (destruction == 0)
                    {
                        
                        porte.GetComponent<Animator>().enabled = true;
                    }


                }
            }
        }
    }
}
