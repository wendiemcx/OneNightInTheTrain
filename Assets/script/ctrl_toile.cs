using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ctrl_toile : MonoBehaviour
{
    ctrl_toile2 toileUI;
   
    public float duration = 5.0f;

    public GameObject ScorePV;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.PV = 100;
        ScorePV = GameObject.Find("Progressbar");
        toileUI = FindObjectOfType<ctrl_toile2>();
    }

    // Update is called once per frame


    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "perso")
        {
            toileUI.DisplayWeb(duration);
            GameManager.PV = GameManager.PV - 10;
            ScorePV.GetComponent<Image>().fillAmount = GameManager.PV / 100.0f;

        }    
        

    }
}
