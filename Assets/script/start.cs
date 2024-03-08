using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject perso;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("debut du jeu");
        //perso.transform.position = new Vector3(13.188f, 0.5f, -12.129f); // position du perso au début du jeu
        perso.transform.position = new Vector3(13.4849997f, 0.5f, 51.125f); // position du perso devant la hache



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
