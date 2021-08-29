using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
     GameObject Zombie;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawning", Random.Range(3f,10f));
    }

    public void Spawning()
    {
        Instantiate(Zombie, transform.position, Quaternion.identity);

        Invoke("Spawning", Random.Range(20f, 30f));

    }
}
