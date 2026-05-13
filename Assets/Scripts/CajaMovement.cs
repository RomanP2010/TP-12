using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        if(GameManager.gameOver == false)
        {
            transform.Translate(0, -speed, 0);
        }
    }
}

