using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ctrl_hache : MonoBehaviour
{

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

            if (Input.GetKey(KeyCode.E))
            {
                Destroy(gameObject);
            }   

        }
    }
}
