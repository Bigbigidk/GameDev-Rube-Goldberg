using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttonpenguin : MonoBehaviour
{
    public GameObject OtherObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.name == "start domino (8)")
        {
            UnityEngine.Object.Destroy(OtherObject, 0);
            UnityEngine.Object.Destroy(this.gameObject, 0);
        }


    }
}

