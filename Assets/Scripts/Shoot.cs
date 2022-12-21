using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float ballSpeed;
    public Transform outPosition;
    OVRGrabbable Grabbable;

    bool startGrab = true;

    private void Start()
    {
        Grabbable = GetComponent<OVRGrabbable>();
    }
    private void Update()
    {
        if (Grabbable.isGrabbed)
        {
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) || OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                /*Instantiate(bullet, shootPoint.position, shootPoint.rotation).GetComponent<Rigidbody>().AddForce(shootPoint.forward * shootForce);*/
                Instantiate(bullet, outPosition.position, outPosition.rotation).GetComponent<Rigidbody>().velocity = outPosition.forward * ballSpeed;
            }
        }else startGrab = true;

        if (Grabbable.isGrabbed && startGrab)
        {
            if (Grabbable.grabbedBy.name.Contains("Right")){
                transform.Rotate(0, 0, 90);
            }
            else transform.Rotate(0, 0, -90);


            transform.Rotate(0,0,0); 
            startGrab = false;
        }
    }
}
