using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Enemy spawns and moves toward player diagonally
        transform.Translate(new Vector3(-1, -1, 0) * Time.deltaTime * 6f);
        //Destroy Parameters 
        if (transform.position.x < -11f)
        {
            Destroy(this.gameObject);
        }
         if (transform.position.y < -4f)
        {
            Destroy(this.gameObject);
        }
       
    }
}
