using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float ballSpeed;
    public Transform outPosition;

    private void Update()
    {
        if(GetComponent<OVRGrabbable>().isGrabbed) {
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
            {
                /*Instantiate(bullet, shootPoint.position, shootPoint.rotation).GetComponent<Rigidbody>().AddForce(shootPoint.forward * shootForce);*/
                Instantiate(bullet, outPosition.position, outPosition.rotation).GetComponent<Rigidbody>().velocity = outPosition.forward * ballSpeed;
            }
        }
    }
}
