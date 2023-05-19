using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject theEnemy ;
    public float xPos;
    public float yPos;
    public float zPos;
    public int EnemyCount;

    private void Start()
    {
        
        xPos=gameObject.transform.position.x;
        yPos=gameObject.transform.position.y;
        zPos=gameObject.transform.position.z;
        StartCoroutine(SpawnEnemies());

    }

    private IEnumerator SpawnEnemies()
    {
        while (EnemyCount < 20)
        {
            
            //Instantiate(theEnemy, new Vector3 (xPos, 14, zPos), Quaternion.identity);
            //GameObject clone = Instantiate(theEnemy, new Vector3 (530, 14, 464), Quaternion.identity);
            GameObject clone = Instantiate(theEnemy, new Vector3 (xPos, yPos, zPos), Quaternion.identity);
            clone.AddComponent<ManipuladorVida>();
            yield return new WaitForSeconds(2);
            EnemyCount += 1;
        }
    }
}
