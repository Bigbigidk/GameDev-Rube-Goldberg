using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttonstart : MonoBehaviour
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

    void OnMouseDown()
    {
        UnityEngine.Object.Destroy(OtherObject, 0);
        UnityEngine.Object.Destroy(this.gameObject, 0);
    }

}

