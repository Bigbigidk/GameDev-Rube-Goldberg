using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonmove2 : MonoBehaviour
{
    int balloontrigger;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        balloontrigger = GameObject.Find("balloon platform2").GetComponent<balloonbutton2>().balloon2;

        Vector3 currentPos = transform.position;

        if (balloontrigger == 1)
        {
            currentPos.y += speed;
        }

        transform.position = currentPos;

    }
}
