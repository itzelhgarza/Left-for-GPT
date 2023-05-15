using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AIEnemyNav : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform movePositionTransform;
    public float life = 3;
    private int puntos;


    void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("buenas");
        if(collision.gameObject.CompareTag("Bullet")){
            life--;
           if(life<1){
            ScoreManager.score= ScoreManager.score + 100;
            Destroy(gameObject);
           }
            
           
            Debug.Log("Holaaaa");
            //txtPuntos.GetComponent<Text>().text=puntos.ToString();
        }else{
            Debug.Log("woa pasar");
        }
        //Destroy(collision.gameObject);
         
        

    }
    // Start is called before the first frame update
    private void Awake(){
        
    }
    void Start()
    {
        navMeshAgent=GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination= movePositionTransform.position;
    }
}
