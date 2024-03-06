using System.Collections;
using System.Collections.Generic;
using SUPERCharacter;
using UnityEngine;
using UnityEngine.UI;

public class ctrl_liquid : MonoBehaviour
{
    ctrl_liquid2 splashUI;
    GameObject player;
    GameObject ScorePV;
    public float duration = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("perso");

        GameManager.PV = 100;
        ScorePV = GameObject.Find("Progressbar");
        splashUI = FindObjectOfType<ctrl_liquid2>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "perso")
        {
            //splashUI.DisplaySplash(duration);
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

        }
    }
}
