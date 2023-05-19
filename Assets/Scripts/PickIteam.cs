using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickIteam : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip clip;
    BarraDeVida playerVida;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Player")){
            
            AudioSource.PlayClipAtPoint(clip,transform.position);
            playerVida = GameObject.FindWithTag("Player").GetComponent<BarraDeVida>();
            playerVida.vida=100;
            Destroy(gameObject);
        
        }else{
            Debug.Log("woa pasar");
        }
        //Destroy(collision.gameObject);
         
        

    }
}
