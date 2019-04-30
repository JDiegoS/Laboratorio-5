using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    private bool derecha = true;
    private bool up = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (derecha == true && transform.position.x < -3)
        {
            transform.position = new Vector3(transform.position.x + 3 * Time.deltaTime, transform.position.y, transform.position.z);
            if (transform.position.x >= -3)
            {
                derecha = false;
                if (up == true && transform.position.z < 9.5)
                {
                    while (transform.position.z < 9.5)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1 * Time.deltaTime);
                    }

                    if (transform.position.z >= 9.5)
                    {
                        up = false;
                    }
                }
                else if (up == false && transform.position.z > 5.5)
                {
                    while (transform.position.z > 5.5)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1 * Time.deltaTime);
                    }

                    if (transform.position.z <= 5.5)
                    {
                        up = true;
                    }
                }
            }
        }
        if (derecha == false && transform.position.x > -27)
        {
            transform.position = new Vector3(transform.position.x - 3 * Time.deltaTime, transform.position.y, transform.position.z);
            if (transform.position.x <= -27)
            {
                derecha = true;
                if (up == true && transform.position.z < 9.5)
                {
                    while (transform.position.z < 9.5)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1 * Time.deltaTime);
                    }

                    if (transform.position.z >= 9.5)
                    {
                        up = false;
                    }
                }
                else if (up == false && transform.position.z > 5.5)
                {
                    while (transform.position.z > 5.5)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1 * Time.deltaTime);
                    }

                    if (transform.position.z <= 5.5)
                    {
                        up = true;
                    }
                }
            }
        }

    }

    //x -27 -3 z 5.5 9.5
}