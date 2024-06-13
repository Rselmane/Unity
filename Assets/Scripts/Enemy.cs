using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxDistance = 5.0f;
    public int damage = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hitinfo;
        if(Physics.Raycast(this.transform.position + new Vector3(0, 1, 0), transform.TransformDirection(Vector3.forward), out hitinfo, Mathf.Infinity, ~(1 << 8)))
        {           
            PlayerController pc;
            if(hitinfo.collider.TryGetComponent<PlayerController>(out pc))
            {
                pc.Damage(this.damage);
            }
        }
    }
}
