using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icesound : MonoBehaviour
{
    AudioSource mySource;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
       mySource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.name == "Penguin ball")
        {
            mySource.PlayOneShot(clip);
        }

    }
}
