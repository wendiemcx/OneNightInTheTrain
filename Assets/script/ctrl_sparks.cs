using System.Collections;
using System.Collections.Generic;
using System.Threading;
using SUPERCharacter;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;
using UnityEngine.UI;


public class ctrl_sparks : MonoBehaviour
{
    public float timer;
    public GameObject player;
    public GameObject ScorePV;
    public GameObject eclair;

    bool isPlayerInTrigger;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("perso");
        player.GetComponent<SUPERCharacterAIO>().currentGroundSpeed = 70;
        timer = 0.0f;
        GameManager.PV = 100;
        ScorePV = GameObject.Find("Progressbar");

    }

    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "perso")
        {
            GameManager.PV = GameManager.PV - 10;
            ScorePV.GetComponent<Image>().fillAmount = GameManager.PV / 100.0f;
            SUPERCharacterAIO playerCharacterAIO = other.GetComponent<SUPERCharacterAIO>();
            Instantiate(eclair, transform.position, Quaternion.identity);

            playerCharacterAIO.chockDuration = 2.0f;
            playerCharacterAIO.currentGroundSpeed = 0;

        }

    }


}
