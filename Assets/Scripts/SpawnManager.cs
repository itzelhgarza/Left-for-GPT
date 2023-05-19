using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] spawners;
    public int EnemyCount;
    public float xPos;
    public float yPos;
    public float zPos;

    public GameObject theEnemy;
    // Start is called before the first frame update
    void Start()
    {
        xPos=gameObject.transform.position.x;
        yPos=gameObject.transform.position.y;
        zPos=gameObject.transform.position.z;
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnEnemies()
    {
        while (EnemyCount < 20)
        {
            GameObject clone = Instantiate(theEnemy, new Vector3 (xPos, yPos, zPos), Quaternion.identity);
            clone.AddComponent<ManipuladorVida>();
            yield return new WaitForSeconds(2);
            EnemyCount += 1;
        }
    }
}
