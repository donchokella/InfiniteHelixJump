using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleRotate : MonoBehaviour
{
    private float touchX;
    public float rotateSpeed;

    private void FixedUpdate()
    {
        SwipeCheck();
    }

    private void SwipeCheck()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchX = Input.GetTouch(0).deltaPosition.x / Screen.width * 30;
        }
        else if (Input.GetMouseButton(0))
        {
            touchX = Input.GetAxis("Mouse X");
        }
        else
        {
            touchX = 0;
        }
        transform.Rotate(0, -touchX * rotateSpeed, 0);
    }
}
