using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    public AudioSource son;
    public AudioClip win;
    public AudioClip collect;
    public AudioClip die;
    public AudioClip background;
    private float masterVolume = 0.1f;
    private float louder = 1f;
    private int conta = 0;
    bool f1 = true;
    bool f2 = true;
    bool f3 = true;
    bool f4 = true;
    bool pl = true;
    // Start is called before the first frame update
    void Start()
    {
        son = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Ficha 1") == null && f1 == true)
        {
            son.PlayOneShot(collect, louder);
            conta += 1;
            f1 = false;
        }
        if (GameObject.Find("Ficha 2") == null && f2 == true)
        {
            son.PlayOneShot(collect, louder);
            conta += 1;
            f2 = false;
        }
        if (GameObject.Find("Ficha 3") == null && f3 == true)
        {
            son.PlayOneShot(collect, louder);
            conta += 1;
            f3 = false;
        }
        if (GameObject.Find("Ficha 4") == null && f4 == true)
        {
            son.PlayOneShot(collect, louder);
            conta += 1;
            f4 = false;
        }
        if (conta == 4)
        {
            son.PlayOneShot(win, louder);
        }
        if (GameObject.Find("Player") == null && pl== true)
        {
            son.PlayOneShot(die, louder);
            pl = false;
        }
    }
    public void SubirVol()
    {
        if (masterVolume < 1.0f && masterVolume >= 0.9f)
        {
            masterVolume = 1.0f;
            son.volume = masterVolume;
        }
        else if (masterVolume < 0.9f)
        {
            masterVolume = masterVolume + 0.1f;
            son.volume = masterVolume;
        }

    }
    public void BajarVol()
    {
        if (masterVolume <= 0.1f && masterVolume >= 0.0f)
        {
            masterVolume = 0.0f;
            son.volume = masterVolume;
        }
        else if (masterVolume > 0.1f)
        {
            masterVolume = masterVolume - 0.1f;
            son.volume = masterVolume;
        }


    }
}
