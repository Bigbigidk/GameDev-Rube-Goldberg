using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonmove : MonoBehaviour
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

        balloontrigger = GameObject.Find("balloon platform").GetComponent<balloonbutton>().balloon;

        Vector3 currentPos = transform.position;

        if(balloontrigger == 1)
        {
            currentPos.y += speed;
        }

        transform.position = currentPos;

    }
}
