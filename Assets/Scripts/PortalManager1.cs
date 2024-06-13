using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    public GameObject portalA;
    public GameObject portalB;

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        Camera cameraA = portalA.GetComponentsInChildren<Camera>()[0];
        Camera cameraB = portalB.GetComponentsInChildren<Camera>()[0];

        if (cameraA.targetTexture != null)
        {
            cameraA.targetTexture.Release();
        }

        cameraA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        portalB.GetComponent<Renderer>().material.mainTexture = cameraA.targetTexture;

        if (cameraB.targetTexture != null)
        {
            cameraB.targetTexture.Release();
        }

        cameraB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        portalA.GetComponent<Renderer>().material.mainTexture = cameraB.targetTexture;
    }
}
