using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsTracker : MonoBehaviour
{
    int shotsFor = 0;
    int shotsAgainst = 0;
    int turnovers = 0;
    int turnoversAgainst = 0;
    int penPasses = 0;
    int penPassesAgainst = 0;
    int PPR = 0;
    int PPRagainst = 0;
    int crossesFor = 0;
    int crossesAgainst = 0;

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

    public void addShotFor()
    {
        shotsFor++;
        shotsForText.text = shotsFor.ToString();
    }

    public void addShotAgainst()
    {
        shotsAgainst++;
        shotsAgainstText.text = shotsAgainst.ToString();
    }

    public void addTurnover()
    {
        turnovers++;
        turnoversText.text = turnovers.ToString();
    }

    public void addTurnoverAgainst()
    {
        turnoversAgainst++;
        turnoversAgainstText.text = turnoversAgainst.ToString();
    }

    public void addPenPass()
    {
        penPasses++;
        penPassesText.text = penPasses.ToString();
    }

    public void addPPAgainst()
    {
        penPassesAgainst++;
        penPassesAgainstText.text = penPassesAgainst.ToString();
    }

    public void addPPR()
    {
        PPR++;
        PPRText.text = PPR.ToString();
    }

    public void addPPRAgainst()
    {
        PPRagainst++;
        PPRagainstText.text = PPRagainst.ToString();
    }

    public void addCrossFor()
    {
        crossesFor++;
        crossesForText.text = crossesFor.ToString();
    }

    public void addCrossAgainst()
    {
        crossesAgainst++;
        crossesAgainstText.text = crossesAgainst.ToString();
    }
}
