using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchEventTrigger : MonoBehaviour
{

    [SerializeField]
    Text printStopwatchTime;

    [SerializeField]
    GameObject gameUI;

    [SerializeField]
    GameObject matchEventUI;

    [SerializeField]
    Text eventInfoText;

    void Start()
    {
        gameUI.SetActive(true);
        matchEventUI.SetActive(false);
    }

    public void OnClicked (Button button)
    {
        //print(button.name);

        string buttonCoordinate = button.GetComponentInChildren<Text>().text;
        print("Event Coordinate: " + buttonCoordinate + " Time: " + printStopwatchTime.GetComponent<Text>().text);

        StopwatchScript eventStopClock = gameObject.GetComponent<StopwatchScript>();
        eventStopClock.StopTimer();

        gameUI.SetActive(false);
        matchEventUI.SetActive(true);

        eventInfoText.text = "Event Coordinate: " + buttonCoordinate + " Time: " + printStopwatchTime.GetComponent<Text>().text;
    }

    public void returnToGame()
    {
        gameUI.SetActive(true);
        matchEventUI.SetActive(false);
    }
}
