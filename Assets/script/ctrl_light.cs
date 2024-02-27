using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ctrl_light : MonoBehaviour
{
    public GameObject faible_light;
    public GameObject forte_light;
    public GameObject Pourcentage;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        Pourcentage = GameObject.Find("AffichePower");
        GameManager.Power = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            faible_light.SetActive(true);
            forte_light.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            faible_light.SetActive(false);
            forte_light.SetActive(true);
        }
            if (forte_light.activeSelf)
            {
                timer = timer + Time.deltaTime;

                if (timer >2.0f) 
                { 
                    GameManager.Power = GameManager.Power - 1;
                    Pourcentage.GetComponent<Text>().text = GameManager.Power.ToString();
                    timer = 0.0f;
                }
            }
        if (GameManager.Power <= 0)
        {
            Destroy(forte_light);
            faible_light.SetActive(true );
        }

        
    }
}
