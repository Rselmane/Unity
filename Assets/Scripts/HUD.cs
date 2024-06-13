using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerController pc = GameObject.Find("Man_Mesh").GetComponent<PlayerController>();
        var elem =  GetComponent<TMPro.TMP_Text>();
        elem.text = pc.health + " / " + pc.maxHealth;
    }
}
