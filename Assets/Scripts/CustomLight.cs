using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomLight : MonoBehaviour
{
    public Light touchLight;
    private bool onLight;

    private void Update()
    {
        if (GetComponent<OVRGrabbable>().isGrabbed)
        {
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    onLight = !onLight;

                    if (onLight) 
                    {
                    touchLight.gameObject.SetActive(true);
                    }else touchLight.gameObject.SetActive(false);
            }
        }
    }
}
