using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ctrl_gameover : MonoBehaviour
{
    public Button New;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        New.onClick.AddListener(action_New);
    }

    void action_New()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
    }

}
