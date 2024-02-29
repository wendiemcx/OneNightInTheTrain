using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionGizmoIndicator : MonoBehaviour
{
    public float verticalOffset;
    public Color gizmoColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Vector3 fromPosition = transform.position + Vector3.up * verticalOffset;
        Gizmos.DrawLine(fromPosition, fromPosition + transform.forward);
    }
}
