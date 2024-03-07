using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ctrl_morceaux : MonoBehaviour
{
    public GameObject ScorePV;
    SpecialVirtualCameraBehaviour specialVirtualCameraBehaviour;
    AudioSource son;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.PV = 100;
        ScorePV = GameObject.Find("Progressbar");
        specialVirtualCameraBehaviour = FindObjectOfType<SpecialVirtualCameraBehaviour>();
        son = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "perso")
        {
            son.Play(0);
            GameManager.PV = GameManager.PV - 10;
            ScorePV.GetComponent<Image>().fillAmount = GameManager.PV / 100.0f;
            specialVirtualCameraBehaviour.PlayImpulse();
        }

    }
}
