using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameManager gm;

    public GameObject[] Item;
    public GameObject[] Fire;
    public GameObject[] Transporter;

    public TextMeshPro score;
    public int point;

    public GameObject[] Collectibles;

    
    public Transform northPoint;
    public Transform southPoint;
    public Transform westPoint;
    public Transform eastPoint;

    public float SpawnDelay = 1;
    float timeElapsed = 0;

    [Range (1,100)]public int cointCount = 100;
    int currentCoinCount = 0;

    public AudioSource audioSource;
    public AudioClip deathClip;
    private void Start()
    {
        //SpawnCoin();
        //InvokeRepeating("SpawnCoin", 2, 2);
    }

    private void Update()
    {
        //Timer3
        if (timeElapsed < SpawnDelay)
        {
            timeElapsed += Time.deltaTime;
        }
        else
        {
            SpawnCoin();
            timeElapsed = 0;
        }

        score.text = "Score: " + point.ToString();
    }

    public void AdjustScore(int value)
    {
        point += value;
    }

    public void SpawnCoin()
    {
        int randomIndex = Random.Range(0, Collectibles.Length);
        Instantiate(Collectibles[randomIndex], SpawnPos(), Quaternion.identity);

    }

    public void PlayDeathSound()
    {
        audioSource.PlayOneShot(deathClip);
    }

    private Vector2 SpawnPos()
    {
        float xValue = Random.Range(westPoint.position.x, eastPoint.position.x);
        float yValue = northPoint.position.y;
        //int zValue = 1;
        Vector3 temp = new Vector3(xValue, yValue, 0);
        //return new Vector2(xValue,yValue);

        return temp;
    }
}
