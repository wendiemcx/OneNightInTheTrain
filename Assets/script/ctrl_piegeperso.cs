using System.Collections;
using System.Collections.Generic;
using SUPERCharacter;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ctrl_piegeperso : MonoBehaviour
{
    public GameObject splash;
    GameObject ScorePV;
    public GameObject player;
    ctrl_piege2 SplashUI;
    public float duration = 1.0f;
    AudioSource son;
    // Start is called before the first frame update
    void Start()
    {
        SplashUI = FindObjectOfType<ctrl_piege2>();
        GameManager.PV = 100;
        ScorePV = GameObject.Find("Progressbar");
        son = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "flaque")
        {
            son.time = 0.7f;
            son.Play(0);
            SplashUI.DisplaySplash(duration);
            //splash.SetActive(true);
            player.GetComponent<SUPERCharacterAIO>().currentGroundSpeed = 30;
            GameManager.PV = GameManager.PV - 10;
            ScorePV.GetComponent<Image>().fillAmount = GameManager.PV / 100.0f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "flaque")
        {
            player.GetComponent<SUPERCharacterAIO>().currentGroundSpeed = 70;
            //splash.SetActive(false);

        }
    }
}
