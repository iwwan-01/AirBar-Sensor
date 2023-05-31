using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SensorTracker : MonoBehaviour
{
    [SerializeField]
    private Vector3 mousePosition;
    [SerializeField]
    private int leftClickCounter;
    [SerializeField]
    private int rightClickCounter;
    [SerializeField]
    private int touchCounter;
    [HideInInspector]
    public string mousePosStr;

    void Update()
    {
        // Mouse 
        mousePosition = Input.mousePosition;
        mousePosStr = mousePosition.ToString();

        // Increments by 1 whenever left mouse button has been pressed down
        if (Input.GetMouseButtonDown(0))
        {
            leftClickCounter++;
        }

        // Increments by 1 whenever right mouse button has been pressed down
        if (Input.GetMouseButtonDown(1))
        {
            rightClickCounter++;
        }

        // Touch

        // Limits the number of touches on the screen to 4
        if (Input.touchCount > 4)
        {
            // Gets the last touch (index - 4)
            Touch touch = Input.GetTouch(4);
            touch.phase = TouchPhase.Canceled;
        }

        // Checks how many touches there are currently on the screen
        if (Input.touchCount > 0) 
        {
            // Gets the first touch (index - 0)
            Touch touch = Input.GetTouch(0);

            // Checks the touch phase
            if(touch.phase == TouchPhase.Ended ) {
                touchCounter++;
            }

        }

        if (Input.touchCount == 2)
        {
            // Gets the second touch (index - 1)
            Touch touch = Input.GetTouch(1);

            // Checks the touch phase 
            if(touch.phase == TouchPhase.Began)
            {
                touchCounter++;
            }
        }
    }
}
