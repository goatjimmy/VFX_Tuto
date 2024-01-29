using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            transform.GetChild(i).GetComponent<ParticleSystem>().Stop();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        for(int i = 0; i < 4; i++)
        {
            transform.GetChild(i).GetComponent<ParticleSystem>().Play();
        }
    }

    public void Stop()
    {
        for (int i = 0; i < 4; i++)
        {
            transform.GetChild(i).GetComponent<ParticleSystem>().Stop();
        }
    }
}
