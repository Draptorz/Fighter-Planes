using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // its access level: public or private
    // its type: int (5, 8, 36, etc.), float (2.5f, 3.7f, etc.)
    // its name: speed, playerSpeed --- Speed, PlayerSpeed
    // optional: give it an initial value
    private float speed;
    public int lives = 3;  
    public int score = 0;
    private float horizontalInput;
    private float verticalInput;

    public GameObject bullet;

    private const int maxLives = 3; 

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);

        // if (condition) { //do this }
        // else if (other condition { //do that }
        // else { //do this final }
        if (transform.position.x > 11.5f || transform.position.x <= -11.5f)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);
        }

        if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y < -4f)
        {
            transform.position = new Vector3(transform.position.x, -4f);
        }
    }

    void Shooting()
    {
        //if I press SPACE
        //Create a bullet
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Create a bullet
            Instantiate(bullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
    public void TakeDamage(int damage)
    {
        lives -= damage;  // Subtract the damage from the player's health
        Debug.Log("Player lives: " + lives);

        if (lives <= 0)
        {
            Die();  // Call the Die() method if health reaches 0
        }
    }
        public void IncreaseLife()
    {
        if (lives < maxLives)  // Only increase lives if it's less than maxLives
        {
            lives += 1;  // Increase the player's lives by 1
            Debug.Log("Player lives increased! Lives: " + lives);
        }
        else
        {
            Debug.Log("Max lives reached!");  // Feedback if player already has max lives
        }
    }
        private void Die()
    {
        Debug.Log("Player has died!");  // You can handle player death here, e.g., reload the level, show a game over screen, etc.
    }
}
