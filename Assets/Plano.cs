using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plano : MonoBehaviour
{
    public GameObject cubo;
    public GameObject ficha;
    public AudioSource son;
    public AudioClip sfx;
    // Start is called before the first frame update
    void Start()
    {
        //son = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plano")
            if (cubo)
            {
                //son.Play();
                Destroy(cubo);
            }
                
    }

    private void OnTriggerStay(Collider other)
    {
        transform.localScale += Vector3.one * 4 * Time.deltaTime;
    }

    //Se diferencian con tags
    //necesitamos manager o singleton
    //monedas como trigger con colision desactivada
}
