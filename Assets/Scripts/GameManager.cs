using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject txtLife, txtScore;
    int life, score;

    // Start is called before the first frame update
    void Start()
    {

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
        
    }
}
