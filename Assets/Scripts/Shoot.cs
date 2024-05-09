using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    public GameManager gm;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }

}
