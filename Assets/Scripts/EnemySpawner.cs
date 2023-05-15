using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject theEnemy ;
    public int xPos;
    public int zPos;
    public int EnemyCount;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (EnemyCount < 20)
        {
            xPos = Random.Range(-16, 13);
            zPos = Random.Range(-20, 1);
            //Instantiate(theEnemy, new Vector3 (xPos, 14, zPos), Quaternion.identity);
            Instantiate(theEnemy, new Vector3 (530, 14, 464), Quaternion.identity);
            yield return new WaitForSeconds(2);
            EnemyCount += 1;
        }
    }
}
