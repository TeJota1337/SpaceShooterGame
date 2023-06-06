using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int kills;

    public void EnemyKilled()
    {
<<<<<<< Updated upstream

    }

    public void SetPoints(int newPoints)
    {
        score = newPoints;
        txtScore.GetComponent<TextMeshProUGUI>().text = "Kills: " + score;
    }

    public void AddPoints (int pointsToAdd)
    {
        score = pointsToAdd;
        txtScore.GetComponent<TextMeshProUGUI>().text = "Kills: " + score;
    }
    // Update is called once per frame
    void Update()
    {
        
=======
        kills++;
        FindObjectOfType<HudScript>().UpdateKills(kills);
>>>>>>> Stashed changes
    }
}
