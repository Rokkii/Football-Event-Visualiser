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

    [SerializeField]
    Text eventWithType;

    [SerializeField]
    GameObject eventRegisteredPanel;

    [SerializeField]
    GameObject viewEventsList;

    /*
    public string[] eventArray;
    int i = 0;
    */

    List<string> eventList = new List<string>();

    void Start()
    {
        gameUI.SetActive(true);
        matchEventUI.SetActive(false);
        viewEventsList.SetActive(false);
    }

    public void OnClicked (Button button)
    {
        //print(button.name);

        string buttonCoordinate = button.GetComponentInChildren<Text>().text;
        print("Event Coordinate: " + buttonCoordinate + " Time: " + printStopwatchTime.GetComponent<Text>().text);

        StopwatchScript eventStopClock = gameObject.GetComponent<StopwatchScript>();
        eventStopClock.StopTimer();

        gameUI.SetActive(false);
        eventRegisteredPanel.SetActive(true);
        viewEventsList.SetActive(false);
        matchEventUI.SetActive(true);

        eventInfoText.text = "Event Coordinate: " + buttonCoordinate + " Time: " + printStopwatchTime.GetComponent<Text>().text;
    }

    public void AddEventType (string eventType)
    {
        viewEventsList.SetActive(true);
        eventRegisteredPanel.SetActive(false);

        eventWithType.text = "(" + eventType + ") " + eventInfoText.text;

        eventList.Add(eventWithType.text);

        /*
        eventArray[i] = eventWithType.text;
        i++;
        */
    }

    public void returnToGame()
    {
        gameUI.SetActive(true);
        viewEventsList.SetActive(false);
        eventRegisteredPanel.SetActive(false);
        matchEventUI.SetActive(false);

        eventList.ForEach(print);
       /* for (int x = 0; x < eventArray.Length; x++)
        {
            print(eventArray[x].ToString());
        }*/
    }
}
