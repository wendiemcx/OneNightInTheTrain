using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ctrl_morceaux : MonoBehaviour
{
    public GameObject ScorePV;
    SpecialVirtualCameraBehaviour specialVirtualCameraBehaviour;
    public bool isActivated = false;

    // Start is called before the first frame update
    void Start()
    {
        isActivated = true;
        GameManager.PV = 100;
        ScorePV = GameObject.Find("Progressbar");
        specialVirtualCameraBehaviour = FindObjectOfType<SpecialVirtualCameraBehaviour>();
;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "perso" && isActivated)
        {

            GameManager.PV = GameManager.PV - 25;
            ScorePV.GetComponent<Image>().fillAmount = GameManager.PV / 100.0f;
            specialVirtualCameraBehaviour.PlayImpulse();
        }

    }
}
