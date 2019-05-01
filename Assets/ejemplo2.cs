using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejemplo2 : MonoBehaviour
{
    public GameObject cubo;
    public GameObject ficha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plano")
            if (cubo)
                Destroy(cubo);
    }

    


    private void OnTriggerStay(Collider other)
    {
        transform.localScale += Vector3.one * 4 *Time.deltaTime;
    }

    //Se diferencian con tags
    //necesitamos manager o singleton
    //monedas como trigger con colision desactivada
}
