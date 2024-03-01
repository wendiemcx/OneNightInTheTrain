using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ctrl_glass : MonoBehaviour
{
    public GameObject hache_affiche;
    public int destruction;
    public GameObject porte;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().enabled = false;
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
                if (Input.GetButtonDown("Fire1"))
                {
                    destruction = destruction -1;
                    if (destruction == 0)
                    {
                        GetComponent<Animator>().enabled = true;
                    }

                }

            }
        }
    }
}
