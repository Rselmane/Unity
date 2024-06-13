using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Startup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
        FindObjectOfType<FirstPersonController>().gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource source = GetComponent<AudioSource>();
        if (!source.isPlaying)
        {
            FindObjectOfType<FirstPersonController>().gameObject.SetActive(false);
            GameObject.Destroy(this);
        }
    }
}
