using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class ctrl_toile2 : MonoBehaviour
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
                gameObject.GetComponent<RawImage>().enabled = false;
            }
        }
    }

    public void DisplayWeb(float duration)
    {
        timer = duration;
        gameObject.GetComponent<RawImage>().enabled = true;
        flag = true;
    }
}
 