using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class ctrl_planches : MonoBehaviour
{
    public GameObject hache_affiche;
    public int destruction;
    public GameObject planches;
    public GameObject hache;
    public GameObject baton;
    public GameObject fer;
    public GameObject bulle;

    public float timer_anim_hache;
    public bool timer_flag;
    AudioSource son;

    // Start is called before the first frame update
    void Start()
    {
        timer_anim_hache = 0;
        timer_flag = false;
        son = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "perso")
        {
            bulle.SetActive(true);
            if (hache_affiche.activeSelf)
            {
                hache.SetActive(true);
                
                if (Input.GetButtonDown("Fire1"))
                {

                    timer_flag = true;

                    hache.GetComponent<Animator>().SetTrigger("tapptrig");      

                }

                if (timer_flag == true)
                {
                    timer_anim_hache += Time.deltaTime; // on déclanche le timer
                }

                if (timer_anim_hache > 0.5f)
                {
                    destruction = destruction - 1;
                    Debug.Log("son de bois qui casse");
                    son.Play(0);

                    if (destruction == 0)
                    {
                        planches.SetActive(false);
                        //hache.SetActive(false); // essayer de comprendre pourquoi unity ne veut pas desactiver la hache
                        baton.SetActive(false);   // en attendant, on desactive le baton 
                        fer.SetActive(false);      // et le fer

                    }

                    timer_anim_hache = 0.0f;
                    timer_flag = false;
                }



            }
        }
    }
}
