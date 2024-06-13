using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        PlayerController playerController;
        if (collider.TryGetComponent<PlayerController>(out playerController))
        {
            if (!playerController.keys.Contains(id))
            {
                playerController.keys.Add(id);
                Object.Destroy(this.gameObject);
            }
        }  
    }
}
