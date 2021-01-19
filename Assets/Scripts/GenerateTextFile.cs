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

    // Variables below for final match data values
    [SerializeField]
    Text shotsForText;

    [SerializeField]
    Text shotsAgainstText;

    [SerializeField]
    Text turnoversText;

    [SerializeField]
    Text turnoversAgainstText;

    [SerializeField]
    Text penPassesText;

    [SerializeField]
    Text penPassesAgainstText;

    [SerializeField]
    Text PPRText;

    [SerializeField]
    Text PPRagainstText;

    [SerializeField]
    Text crossesForText;

    [SerializeField]
    Text crossesAgainstText;

    // Variables for user input
    [SerializeField]
    Text myTeamName;

    [SerializeField]
    Text opponentsName;

    [SerializeField]
    Text matchDate;

    public void CreateFileOfEvents()
    {
        string path = Application.dataPath + "/MatchLog.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Match Log \n\n");
        }

        // Add match events to content string
        string content = "Match Log\n\n";

        content += "My Team:        " + myTeamName.text + "\n";
        content += "Opponents:      " + opponentsName.text + "\n";
        content += "Match Date:     " + matchDate.text + "\n";
        content += "\n\n";

        content += "All Match Events:" + "\n\n" + finalEventsList.text + "\n\n";

        // Add match data to string
        content += "Match Data:" + "\n\n";

        content += "Shots For:          " + shotsForText.text + "\n";
        content += "Turnovers For:      " + turnoversText.text + "\n";
        content += "Crosses For:        " + crossesForText.text + "\n";
        content += "PP For:             " + penPassesText.text + "\n";
        content += "PP Received For:    " + PPRText.text + "\n";

        content += "\n";

        content += "Shots Against:         " + shotsAgainstText.text + "\n";
        content += "Turnovers Against:     " + turnoversAgainstText.text + "\n";
        content += "Crosses Against:       " + crossesAgainstText.text + "\n";
        content += "PP Against:            " + penPassesAgainstText.text + "\n";
        content += "PP Received Against:   " + PPRagainstText.text + "\n";

        File.WriteAllText(path, content);

        ingameAllEventsList.text = finalEventsList.text;

    }
}
