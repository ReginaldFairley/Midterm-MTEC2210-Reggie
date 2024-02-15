using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 5;
    float turboSpeed = 10;
    float currentSpeed;

    public SpirteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        //sr = GetComponent<SpriteRenderer<();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
		{
            currentSpeed = turboSpeed;
		}

        else
		{
            currentSpeed = speed;
		}

        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");
        transform.Translate(xMove * currentSpeed * Time.deltaTime, yMove * currentSpeed * Time.deltaTime, 0);

    }
}
