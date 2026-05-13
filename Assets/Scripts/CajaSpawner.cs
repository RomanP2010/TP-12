using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CajaSpawner : MonoBehaviour
{
    int randomNumber;

    public float startYValue;

    public float speed = 0.7f;

    void Start()
    {
       LocateBoxAtRandomPosition(); 
    }

    void Update()
    {
        if(GameManager.gameOver == false)
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
    }

    public void LocateBoxAtRandomPosition()
    {
        Vector3 currentPosition = transform.position;

        float newX = 0f;

        randomNumber = Random.Range(0,3);

        if(randomNumber == 0)
        {
            newX = -2f;
        }
        else if(randomNumber == 1)
        {
            newX = 0f;
        }
        else if(randomNumber == 2)
        {
            newX = 2f;
        }

        currentPosition.x = newX;
        currentPosition.y = startYValue;

        transform.position = currentPosition;
    }
}

