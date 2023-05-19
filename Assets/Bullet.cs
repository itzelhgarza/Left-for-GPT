using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using ScoreManager;

public class Bullet : MonoBehaviour
{
    
    public float life = 3;
    private int puntos;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    public void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("buenas");
        if(other.gameObject.CompareTag("Enemy")){
           
            ScoreManager.score= ScoreManager.score + 10;
           
            Debug.Log("Holaaaa");
            //txtPuntos.GetComponent<Text>().text=puntos.ToString();
        }else{
            Debug.Log("woa pasar");
        }
        //Destroy(collision.gameObject);
         Destroy(gameObject);
        

    }

    public void OnCollisionEnter(Collision other)
    {
        
         Destroy(gameObject);
        
    }
}
