using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public GameObject healthPack;

    // Start is called before the first frame update
    void Start()
    {
        GameObject instantiatedPlayer = Instantiate(player, transform.position, Quaternion.identity);
        instantiatedPlayer.layer = LayerMask.NameToLayer("PlayerLayer"); 
        InvokeRepeating("CreateEnemy", 1f, 3f);
        InvokeRepeating("CreateHealth", 2f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 9f, 0), Quaternion.identity);
    }

    void CreateHealth()
    {
        Debug.Log("health pack created");
       float spawnY = Random.Range(-5f, 0f);
       float spawnX = Random.Range(-7f, 7f);
        GameObject health = Instantiate(healthPack, new Vector3(spawnX, spawnY, 0), Quaternion.identity);
        health.layer = LayerMask.NameToLayer("HealthPackLayer"); 
    }
}
