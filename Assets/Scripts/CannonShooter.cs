using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooter : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject objectToClone;
    public float shootForce = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        //if (Input.GetMouseButton(0))
        {
            Debug.Log("Debug Teste Tiro!");
            ShootCanon();
        }

    }

    public void ShootCanon()
    {
        GameObject aux;
        aux = Instantiate(objectToClone);
        aux.transform.position = spawnPoint.position;
        aux.transform.rotation = spawnPoint.rotation;
        aux.transform.Rotate(new Vector3(90, 0, 0));
        aux.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shootForce, ForceMode.Impulse);

        Destroy(aux, 1);
    }

}
