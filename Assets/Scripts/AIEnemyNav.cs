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


    public void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("buenas");
        if(other.gameObject.CompareTag("Bullet")){
            life--;
           if(life<1){
            ScoreManager.score= ScoreManager.score + 100;
            Destroy(gameObject);
           }
            
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
        movePositionTransform=GameObject.FindWithTag("Player").GetComponent<Transform>();
        navMeshAgent=GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination= movePositionTransform.position;
    }
}
