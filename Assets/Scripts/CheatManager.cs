using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatManager : MonoBehaviour
{
    public int numKeys = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("f5")) {
            PlayerController pc = GameObject.Find("Man_Mesh").GetComponent<PlayerController>();
            pc.keys.Clear();

            for(int i = 0; i < numKeys; i++) {
                pc.keys.Add(i);
            }
        }
    }
}
