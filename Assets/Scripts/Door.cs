using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
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

    private void OnTriggerEnter(Collider other)
    {
        PlayerController playerController;
        if (other.TryGetComponent<PlayerController>(out playerController))
        {
            if (playerController.keys.Contains(id))
            {
                Object.Destroy(gameObject);
            }
        }
    }
}
