using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cart : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;
        transform.position = currentPos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 currentPos = transform.position;

        if (collision.gameObject.transform.name == "Penguin ball")
        {
            currentPos.x += speed;
        }

        transform.position = currentPos;

    }
}
