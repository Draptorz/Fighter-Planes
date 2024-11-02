using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private float x;

    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(x, -1, 0) * Time.deltaTime * 3f);

        if (transform.position.y < -8.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
