using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManipuladorVida : MonoBehaviour
{
    BarraDeVida playerVida;

    int cantidad = -20;
    float damageTime = 0.25f;
    float currentDamageTime;

    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<BarraDeVida>();
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
            currentDamageTime += Time.deltaTime;
            print(currentDamageTime+" yyyyy "+Time.deltaTime);
            if(currentDamageTime > damageTime)
            {
                print("Holeeeeeeeeee");
                print(playerVida);
                playerVida.vida += cantidad;
                currentDamageTime = 0.0f;
            }
        }
    }
    /* public void OnTriggerStay(Collider other){
        if(other.tag =="Player"){
            playerVida.vida += cantidad;
            StartCoroutine(DelayMethod(3));
            //currentDamageTime = 0.0f;
        }
    }

    private IEnumerator DelayMethod(float delayTime)
    {
        float timer = 0;

        while (timer < delayTime)
        {
            timer += Time.deltaTime;
            yield return null;
        }

        Debug.Log("Después del retraso");
    }*/
}
