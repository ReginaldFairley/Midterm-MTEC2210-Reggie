using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coinPrefab;
    public Transform northPoint;
    public Transform southPoint;
    public Transform westPoint;
    public Transform eastPoint;

    public float coinSpawnDelay = 2;
    float timeElapsed = 0;

    [Range (1,10)]public int cointCount = 5;
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
        //Timer
        if (timeElapsed < coinSpawnDelay)
        {
            timeElapsed += Time.deltaTime;
        }
        else
        {
            SpawnCoin();
            timeElapsed = 0;
        }
        
    }

    public void SpawnCoin()
    {
        if (currentCoinCount < cointCount)
        {
            GameObject coinClone = Instantiate(coinPrefab, SpawnPos(), Quaternion.identity);
            currentCoinCount++;
        }

    }

    public void PlayDeathSound()
    {
        audioSource.PlayOneShot(deathClip);
    }

    private Vector2 SpawnPos()
    {
        float xValue = Random.Range(westPoint.position.x, Screen.width);
        float yValue = Random.Range(northPoint.position.y, Screen.height);
        Vector2 temp = new Vector2(xValue, yValue);
        //return new Vector2(xValue,yValue);

        return temp;
    }
}
