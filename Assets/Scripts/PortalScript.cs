using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public Transform targetPos;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider collision)
    {
        CharacterController controller = collision.GetComponent<CharacterController>();
        if (controller != null)
        {
            controller.enabled = false;
        }

        collision.transform.position = targetPos.position;
        collision.transform.rotation = new Quaternion(targetPos.rotation.x, targetPos.rotation.y, targetPos.rotation.z, targetPos.rotation.w);

        if (controller != null)
        {
            controller.enabled = true;
        }
    }
}
