using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using ScoreManager;

public class Bullet : MonoBehaviour
{
    //public ScoreManager sm;
    
    public float life = 3;
    private int puntos;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("buenas");
        if(collision.gameObject.CompareTag("Enemy")){
           
            ScoreManager.score= ScoreManager.score + 10;
           
            Debug.Log("Holaaaa");
            //txtPuntos.GetComponent<Text>().text=puntos.ToString();
        }else{
            Debug.Log("woa pasar");
        }
        //Destroy(collision.gameObject);
         Destroy(gameObject);
        

    }
}
