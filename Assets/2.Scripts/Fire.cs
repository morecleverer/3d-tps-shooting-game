using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject projectile = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject; //Spawns the selected projectile

            projectile.GetComponent<Rigidbody>().AddForce(transform.forward*5000);
            
        }

    }
}
