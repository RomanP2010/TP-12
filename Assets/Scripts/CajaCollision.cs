using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Caja"))
        {
            // aumenta velocidad
            CajaMovement cajaMovement = col.gameObject.GetComponent<CajaMovement>();

            cajaMovement.speed += 0.05f;

            // reubica la caja
            CajaSpawner cajaSpawner = col.gameObject.GetComponent<CajaSpawner>();

            cajaSpawner.LocateBoxAtRandomPosition();
        }
    }
}