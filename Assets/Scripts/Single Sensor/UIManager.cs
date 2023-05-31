using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private SensorTracker sensorTracker;
    private Text mousePosText;

    void Awake()
    {
        sensorTracker = GameObject.Find("Single Sensor").GetComponent<SensorTracker>();
        mousePosText = GameObject.Find("Single Sensor").GetComponent<Text>();
    }

    void LateUpdate()
    {
        mousePosText.text = sensorTracker.mousePosStr;
    }
}
