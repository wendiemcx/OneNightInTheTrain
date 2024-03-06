using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ctrl_piege2 : MonoBehaviour
{
    float timer;
    bool flag;

    void Update()
    {
        if (flag)
        {
            timer = timer - Time.deltaTime;

            if (timer <= 0.0f)
            {
                flag = false;
                gameObject.GetComponent<Image>().enabled = false;
               gameObject.GetComponent<Animator>().enabled = false;
            }
        }
    }

    public void DisplaySplash(float duration)
    {
        timer = duration;
        gameObject.GetComponent<Image>().enabled = true;
        gameObject.GetComponent<Animator>().enabled = true;
        flag = true;
    }
}

