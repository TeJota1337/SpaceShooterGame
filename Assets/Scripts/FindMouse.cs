using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Converte a posição do mouse na tela para uma posição no mundo
  

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePosition = new Vector3(mousePosition.x, 7.5f, mousePosition.z);

        // Faz o personagem olhar para a posição do mouse
        transform.LookAt(new Vector3(mousePosition.x, mousePosition.y, transform.position.z));
    }
}
