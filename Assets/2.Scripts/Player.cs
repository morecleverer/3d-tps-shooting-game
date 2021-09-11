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
    public GameObject tpsCamera;
    public bool isDie;
    public Text text;

    int score = 0;


    vThirdPersonCamera a;


    // Start is called before the first frame update
    void Start()
    {
        a = tpsCamera.GetComponent<vThirdPersonCamera>();
        isDie = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            isDie = true;
            health = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            a.lockCamera = true;

            Time.timeScale = 0;

            GameOver.SetActive(true);
        }

        image.rectTransform.localScale = new Vector3(health / 100, 1, 1);
    }

    public void REPLAY()
    {
        SceneManager.LoadScene(0);
    }

    public void ScoreUp()
    {
        score++;
        text.text = string.Format("kill : {0}", score);
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
