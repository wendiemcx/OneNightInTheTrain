using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ctrl_toile : MonoBehaviour
{
    public ctrl_toile2 toile;
   
    public float duration = 5.0f;

    public GameObject ScorePV;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.PV = 100;
        ScorePV = GameObject.Find("Progressbar");
    }

    // Update is called once per frame


    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "perso")
        {
            toile.DisplayWeb(duration);
            GameManager.PV = GameManager.PV - 10;
            ScorePV.GetComponent<Image>().fillAmount = GameManager.PV / 100.0f;

        }    
        

    }
}
