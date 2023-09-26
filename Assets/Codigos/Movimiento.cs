using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Transform puntoInicial;
    public Transform puntoFinal; 
    public float velocidad = 2.0f;

    private bool enDireccionFinal = true;

    void Update()
    {
        if (enDireccionFinal)
        {
            transform.position = Vector3.MoveTowards(transform.position, puntoFinal.position, velocidad * Time.deltaTime);
            

            if (transform.position == puntoFinal.position)
            {
                transform.position = puntoInicial.position;
                enDireccionFinal = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, puntoInicial.position, velocidad * Time.deltaTime);


            if (transform.position == puntoInicial.position)
            {
                enDireccionFinal = true;
            }
        }
    }
}
