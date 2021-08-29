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
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }
    RaycastHit hit;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100f)) //Finds the point where you click with the mouse
            {
                GameObject projectile = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject; //Spawns the selected projectile
                projectile.transform.LookAt(hit.point); //Sets the projectiles rotation to look at the point clicked
                projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * speed); //Set the speed of the projectile by applying force to the rigidbody
            }
        }

    }
}
