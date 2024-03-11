using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl_cat : MonoBehaviour
{
    public GameObject cat;

    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name =="perso")
        {
            if (GameManager.PV >= 80)
            {
                cat.SetActive(true);
            }
            

        }

    }
}
