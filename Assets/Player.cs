using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
    
{
    public AudioSource sonido;
    public Rigidbody cubo;
    public Rigidbody player;
    public bool muerto = false;
    // Start is called before the first frame update
    void Start()
    {
        //sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            cubo.AddForce(0, 0, 8);
        }
        if (Input.GetKey("s"))
        {
            cubo.AddForce(0, 0, -8);
        }
        if (Input.GetKey("a"))
        {
            cubo.AddForce(-8, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            cubo.AddForce(8, 0, 0);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plano")
            if (cubo)
            {
                //sonido.Play();
                player = cubo;
                Destroy(cubo);
                muerto = true;
            }

                

    }


}
