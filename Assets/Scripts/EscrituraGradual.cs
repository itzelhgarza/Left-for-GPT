using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscrituraGradual : MonoBehaviour
{
    public float velocidadEscritura;
    public AudioClip audioClip;
    private AudioSource audioSource;

    public Text texto;
    private string textoCompleto;
    private float tiempoAcumulado;

    private void Start()
    {
        texto = GetComponent<Text>();
        textoCompleto = texto.text;
        texto.text = "";
        tiempoAcumulado = 0f;
        
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    private void Update()
    {
        tiempoAcumulado += Time.deltaTime;

        if (tiempoAcumulado >= velocidadEscritura)
        {
            tiempoAcumulado = 0f;

            if (texto.text.Length < textoCompleto.Length)
            {
                int caracteresMostrados = texto.text.Length + 1;
                texto.text = textoCompleto.Substring(0, caracteresMostrados);
            }
        }
    }
}