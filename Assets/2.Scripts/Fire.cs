using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public int speed = 2000;
    public GameObject bullet;
    public Transform thirdCamPos;
    public Player player;
    //public Transform firePos;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player = GetComponentInParent<Player>();
    }
    RaycastHit hit;
    // Update is called once per frame
    void Update()
    {

        Debug.DrawRay(thirdCamPos.position, thirdCamPos.forward * 200.0f, Color.green);

        RaycastHit temp;

        
            if (Input.GetKeyDown(KeyCode.Mouse0) && !player.isDie)
        {
            if (Physics.Raycast(thirdCamPos.position, thirdCamPos.forward, out temp, 200.0f)) // 카메라의 위치에서 카메라가 바라보는 정면으로 레이를 쏴서 충돌확인
            {
                
                GameObject projectile = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject; //Spawns the selected projectile
                projectile.transform.LookAt(temp.point); //Sets the projectiles rotation to look at the point clicked
                projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * speed); //Set the speed of the projectile by applying force to the rigidbody
                Debug.DrawRay(transform.position, transform.forward * 10.0f, Color.cyan);
            }
            /*if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100f)) //Finds the point where you click with the mouse
            {
                GameObject projectile = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject; //Spawns the selected projectile
                projectile.transform.LookAt(hit.point); //Sets the projectiles rotation to look at the point clicked
                projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * speed); //Set the speed of the projectile by applying force to the rigidbody
            }*/
        }

    }
}
