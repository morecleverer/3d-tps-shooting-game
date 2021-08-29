using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float health = 100f;
    public Image image;
    public GameObject GameOver;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            health = 0;
            
            GameOver.SetActive(true);
        }

        image.rectTransform.localScale = new Vector3(health / 100, 1, 1);
    }

    public void REPLAY()
    {
        
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            health -= 10f;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.layer == 9)
        {
            health -= 5f* Time.deltaTime;
        }
    }
}
