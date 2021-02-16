using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour
{
    public float ft;
    private bool faded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        if (faded == false)
        {
            if (Input.GetKeyDown("f"))
            {
                StartCoroutine("FadeOut");
            }
        }
        else
        {
            if (Input.GetKeyDown("f"))
            {
                StartCoroutine("FadeIn");
            }
        }
    }

    private IEnumerator FadeOut()
    {
        for (float ft = 1f; ft >= 0; ft -= 0.01f)
        {
            Color c = GetComponent<Renderer>().material.color;
            c.a = ft;
            GetComponent<Renderer>().material.color = c;
            faded = true;
            yield return null;
        }
    }

    private IEnumerator FadeIn()
    {
        for (ft = 0; ft <= 1; ft += 0.01f)
        {
            Color c = GetComponent<Renderer>().material.color;
            c.a = ft;
            GetComponent<Renderer>().material.color = c;
            faded = false;
            yield return null;
        }
    }


}
