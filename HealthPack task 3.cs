using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public float destroyAfterSeconds = 5f;

    void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collided with Health Pack");
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                player.IncreaseLife();
                Debug.Log("Health pack collected! Player lives: " + player.lives);
                Destroy(gameObject);   
            }
            else
            {
                Debug.LogWarning("Player component not found on the player object!");
            }
        }
    }

}
