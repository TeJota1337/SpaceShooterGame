using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameManager gameManagerReference;
    // Start is called before the first frame update
    void Start()
    {
        gameManagerReference = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
