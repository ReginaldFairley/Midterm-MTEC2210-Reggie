using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 10;
    float turboSpeed = 15;
    float currentSpeed;
    public AudioClip clip;
    public AudioClip clip2;
    AudioSource audioSource;
    public GameManager gm;

    public item lastItemCollided;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
        transform.Translate(xMove * currentSpeed * Time.deltaTime, 0, 0);

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.tag == "Fire")
		{
            gm.PlayDeathSound();
            //audioSource.PlayOneShot(clip);
            Destroy(gameObject);
        }

        else if (collision.tag == "Banana")
        {
            lastItemCollided = collision.gameObject.GetComponent<item>();
            audioSource.PlayOneShot(clip2);
            Destroy(collision.gameObject);
            int tempValue = collision.gameObject.GetComponent<item>().value;
            gm.AdjustScore(tempValue);
            
        }

        else if (collision.gameObject.tag == "Transporter")
        {
            Debug.Log("Teleport to next theme");
            lastItemCollided = collision.gameObject.GetComponent<item>();
        }    

	}

}
