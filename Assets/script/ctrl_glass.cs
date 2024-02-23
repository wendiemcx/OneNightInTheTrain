using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl_glass : MonoBehaviour
{
    public GameObject hache_affiche;
    public int destruction;
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
                if (Input.GetButtonDown("Fire1"))
                {
                    destruction = destruction -1;
                    if (destruction == 0)
                    {
                        Destroy(gameObject);
                    }

                }

            }
        }
    }
}
