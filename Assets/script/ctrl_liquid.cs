using System.Collections;
using System.Collections.Generic;
using SUPERCharacter;
using UnityEngine;
using UnityEngine.UI;

public class ctrl_liquid : MonoBehaviour
{
    GameObject player;
    GameObject ScorePV;

    public GameObject splash;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("perso");

        GameManager.PV = 100;
        ScorePV = GameObject.Find("Progressbar");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "perso")
        {
            splash.SetActive(true);
            other.GetComponent<SUPERCharacterAIO>().currentGroundSpeed = 30;
            GameManager.PV = GameManager.PV - 10;
            ScorePV.GetComponent<Image>().fillAmount = GameManager.PV / 100.0f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "perso")
        {
            other.GetComponent<SUPERCharacterAIO>().currentGroundSpeed = 70;
            splash.SetActive(false);
        }
    }
}
