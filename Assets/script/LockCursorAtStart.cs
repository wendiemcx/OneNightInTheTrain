using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursorAtStart : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
