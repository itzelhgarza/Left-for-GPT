using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AIEnemyNav : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public GameObject itemDrop;
    [SerializeField] private Transform movePositionTransform;
    public float life = 3;
    private int puntos;
    private float xPos;
    private float yPos;
    private float zPos;
    public AudioClip clip;
    public void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("buenas");
        if(other.gameObject.CompareTag("Bullet")){
            life--;
           if(life<1){
            ScoreManager.score= ScoreManager.score + 100;
            int random = Random.Range(1,6);
            if(random==1){
                xPos=gameObject.transform.position.x;
                yPos=gameObject.transform.position.y;
                zPos=gameObject.transform.position.z;
                GameObject clone = Instantiate(itemDrop, new Vector3 (xPos, yPos, zPos), Quaternion.identity);
            }
            AudioSource.PlayClipAtPoint(clip,transform.position);
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
        Vector3 direction = movePositionTransform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 10);
    }
}
