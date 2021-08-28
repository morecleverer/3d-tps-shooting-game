using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public int speed = 1000;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject projectile = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject; //Spawns the selected projectile

            projectile.GetComponent<Rigidbody>().AddForce(transform.forward*speed);
            
        }

    }
}
