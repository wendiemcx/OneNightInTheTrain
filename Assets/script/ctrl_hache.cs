using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ctrl_hache : MonoBehaviour
{
    public GameObject hache_affiche;

    // Start is called before the first frame update
    void Start()
    {
        hache_affiche.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "perso")
        {

            if (Input.GetKey(KeyCode.E))
            {

                Destroy(gameObject);
                hache_affiche.SetActive(true);
            }   

        }
    }
}
