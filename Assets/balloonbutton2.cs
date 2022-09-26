using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonbutton2 : MonoBehaviour
{
    public GameObject OtherObject;
    public int balloon2;
    // Start is called before the first frame update
    void Start()
    {

        balloon2 = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.name == "Penguin ball")
        {
            balloon2 = 1;

        }
    }
}
