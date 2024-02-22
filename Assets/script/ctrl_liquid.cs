using System.Collections;
using System.Collections.Generic;
using SUPERCharacter;
using UnityEngine;

public class ctrl_liquid : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("perso");

        player.GetComponent<SUPERCharacterAIO>().walkingSpeed = 70;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "perso")
        {
            other.GetComponent<SUPERCharacterAIO>().walkingSpeed = 30;
        }
    }
}
