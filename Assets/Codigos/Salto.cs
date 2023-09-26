using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public float velocidadElevacion = 2.0f;
    public float limiteElevacion = 5.0f;
    public float tiempoRecarga = 2.0f;

    private bool MousePresionado;
    private float tiempoSinPresionar;
    public bool recargando;

    void Update()
    {
        if (recargando)
        {
            tiempoSinPresionar += Time.deltaTime;
            if (tiempoSinPresionar >= tiempoRecarga)
            {
                tiempoSinPresionar = 0.0f;
                recargando = false;
            }
        }

        if (Input.GetMouseButton(0))
        {
            MousePresionado = true;

            if (!recargando && transform.position.y < limiteElevacion)
            {
                transform.Translate(Vector3.up * velocidadElevacion * Time.deltaTime);
            }
        }
        else
        {
            MousePresionado = false;

            if (transform.position.y >= limiteElevacion)
            {
                recargando = true;
            }
        }
    }
}



