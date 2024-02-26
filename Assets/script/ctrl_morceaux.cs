using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ctrl_morceaux : MonoBehaviour
{
    public GameObject ScorePV;
    // Start is called before the first frame update
    void Start()
    {
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
        GameManager.PV = GameManager.PV - 10;
        ScorePV.GetComponent<Image>().fillAmount = GameManager.PV / 100.0f;
        }

    }
}
