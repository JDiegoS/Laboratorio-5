using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ficha : MonoBehaviour
{
    public GameObject ficha;
    bool up = true;
    public AudioSource s;
    // Start is called before the first frame update
    void Start()
    {
        s = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {



        if (up == true && transform.position.y < 1.25)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1 * Time.deltaTime, transform.position.z);
            if (transform.position.y >= 1.2)
            {
                up = false;
            }
        }
        if (up == false && transform.position.y > 0.55)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1 * Time.deltaTime, transform.position.z);
            if (transform.position.y <= 0.55)
            {
                up = true;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //s.Play();
            Destroy(ficha);
        }
    }
}
