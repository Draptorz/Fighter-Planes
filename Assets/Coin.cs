using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin : MonoBehaviour
{

    private float moveSpeed = 2f;
    private float moveRange = 10.5f;

    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
    float oscillation = Mathf.Sin(Time.time * moveSpeed) * moveRange;

    transform.position = new Vector3(startPos.x + oscillation, transform.position.y, 0);
    }

     private void OnTriggerEnter2D(Collider2D whatIHit)
    {
        if (whatIHit.tag == "Player")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(3);
            Destroy(this.gameObject);
        }
    }


}



