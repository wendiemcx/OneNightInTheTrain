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
    // Start is called before the first frame update
    void Start()
    {
        
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
                hache.SetActive(true);
                
                if (Input.GetButtonDown("Fire1"))
                {
                    hache.GetComponent<Animator>().SetBool("tapp", true);
                    destruction = destruction - 1;

                    if (destruction == 0)
                    {
                        Destroy(planches);
                        hache.SetActive(false);
                    }

                }

            }
        }
    }
}
