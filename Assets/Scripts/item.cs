using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public float minSpeed = -5f;
    public float maxSpeed = -10f;
    private float fallingSpeed;


    // Start is called before the first frame update
    private void Start()
    {

        fallingSpeed = Random.Range(minSpeed, maxSpeed);
    }
       
    

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(0, fallingSpeed * Time.deltaTime, 0);
    }

}