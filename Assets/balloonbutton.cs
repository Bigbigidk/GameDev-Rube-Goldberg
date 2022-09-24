using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonbutton : MonoBehaviour
{
    public GameObject OtherObject;
    static int balloon = 0;
    // Start is called before the first frame update
    void Start()
    {

     balloon = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.name == "Penguin ball")
        {
           balloon = 1;

        }
    }
}
