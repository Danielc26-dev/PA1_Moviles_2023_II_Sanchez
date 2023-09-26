using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public float puntajePorSegundo = 1;

    private float tiempoVivo = 0f;
    private float puntajeTotal = 0;

    public string textValue;
    public TMP_Text TextElement;

    void Update()
    {

        puntajeTotal = puntajeTotal + puntajePorSegundo;

        textValue = "Puntaje: " + puntajeTotal;

        TextElement.text = textValue;
    }
}
