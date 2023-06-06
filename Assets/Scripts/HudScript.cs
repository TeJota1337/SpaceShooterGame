using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HudScript : MonoBehaviour
{
    public TMP_Text Life;
    public TMP_Text Kills;
<<<<<<< Updated upstream
    public int kills;
=======
>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Start()
    {
        UpdateLife(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLife(int valor)
    {
        Life.text = "Life: " + valor;
    }

<<<<<<< Updated upstream
    public void UpdateKills()
    {
        kills++;
        Kills.text = "Kills: " + kills;
=======
    public void UpdateKills(int valor)
    {
        Kills.text = "Kills: " + valor;
>>>>>>> Stashed changes
    }
}

