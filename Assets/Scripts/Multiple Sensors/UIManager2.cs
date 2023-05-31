using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager2 : MonoBehaviour
{
    private MultipleSensorsTracker multipleSensorsTracker;
    private Text messageText;

    // Start is called before the first frame update
    void Start()
    {
        multipleSensorsTracker = GameObject.Find("Multiple Sensors").GetComponent<MultipleSensorsTracker>();
        messageText = GameObject.Find("Multiple Sensors").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        messageText.text = "Touch: " + multipleSensorsTracker.message + "in direction" + multipleSensorsTracker.direction;
    }
}
