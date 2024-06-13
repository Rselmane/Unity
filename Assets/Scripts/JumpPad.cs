using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
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
            controller.Move(new Vector3(0, 100, 100) * Time.deltaTime);
        }
    }
}