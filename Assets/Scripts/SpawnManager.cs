using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] spawners;
    public int EnemyCount;
    public float xPos;
    public float yPos;
    public float zPos;

    private int enemySpawned=0;
    private int enemySpeed=10;
    public GameObject theEnemy;
    // Start is called before the first frame update
    void Start()
    {
        spawners=GameObject.FindGameObjectsWithTag("Spawner");
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnEnemies()
    {
        while (EnemyCount < 60)
        {
            if(enemySpawned<5){
                enemySpeed+=3;
                enemySpawned=0;
            }
            enemySpawned++;
            int random = Random.Range(0,spawners.Length);
            GameObject spawner = spawners[random];
            xPos=spawner.transform.position.x;
            yPos=spawner.transform.position.y;
            zPos=spawner.transform.position.z;
            GameObject clone = Instantiate(theEnemy, new Vector3 (xPos, yPos, zPos), Quaternion.identity);
            clone.GetComponent<NavMeshAgent>().speed=enemySpeed;
            clone.AddComponent<ManipuladorVida>();
            yield return new WaitForSeconds(2);
            EnemyCount += 1;
        }
    }
}
