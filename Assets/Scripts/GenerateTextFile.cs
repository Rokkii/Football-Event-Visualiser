using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GenerateTextFile : MonoBehaviour
{
    [SerializeField]
    Text finalEventsList;

    [SerializeField]
    Text ingameAllEventsList;

    public void CreateFileOfEvents()
    {
        string path = Application.dataPath + "/MatchLog.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Match Log \n\n");
        }

        File.WriteAllText(path, finalEventsList.text);

        ingameAllEventsList.text = finalEventsList.text;

    }
}
