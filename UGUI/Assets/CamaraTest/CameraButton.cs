using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraButton : MonoBehaviour
{
    public Transform target; 
    public float smoothSpeed = 5f;
    public Vector3 offset;

    private Button moveButton;

    private bool isMoving = false;

    void Start()
    {
       
    }

    public void MoveCamera()
    {
        isMoving = true;
    }

    void LateUpdate()
    {
        if (isMoving)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;

            //transform.LookAt(target);
        }
    }
}
