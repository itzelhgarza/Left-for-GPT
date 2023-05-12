using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManipuladorVida : MonoBehaviour
{
    BarraDeVida playerVida;

    public int cantidad;
    public float damageTime;
    float currentDamageTime;

    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<BarraDeVida>();
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            currentDamageTime += Time.deltaTime;
            if(currentDamageTime > damageTime)
            {
                print(playerVida);
                playerVida.vida += cantidad;
                currentDamageTime = 0.0f;
            }
        }
    }
}
