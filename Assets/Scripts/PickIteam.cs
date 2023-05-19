using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickIteam : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip clip;
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
            Destroy(gameObject);
        
        }else{
            Debug.Log("woa pasar");
        }
        //Destroy(collision.gameObject);
         
        

    }
}
