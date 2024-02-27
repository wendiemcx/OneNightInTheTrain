using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl_gaz : MonoBehaviour
{
    public Rigidbody gaz;
    public Transform[] gazMovementPoints;

    public float gazSpeed;

    int currentPointIndex;
    // Start is called before the first frame update
    void Start()
    {
        gaz.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(currentPointIndex < gazMovementPoints.Length)
        {
            Transform currentPoint = gazMovementPoints[currentPointIndex];
            Vector3 moveVector = (currentPoint.position - gaz.transform.position).normalized;
            Vector3 addedPosition = moveVector * gazSpeed * Time.deltaTime;
            gaz.MovePosition(gaz.position + addedPosition);
            if (Vector3.Distance(gaz.position, currentPoint.position)<1)
            {
                currentPointIndex++;
            }
        }

        
    }

    private void OnDrawGizmos()
    {
        for (int i = 0; i < gazMovementPoints.Length -1; i++) 
        {
            Gizmos.DrawLine(gazMovementPoints[i].position, gazMovementPoints[i + 1].position);       
        }
    }
}
