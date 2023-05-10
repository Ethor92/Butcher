using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class CameraConstraint : MonoBehaviour
{
    private FirstPersonController controller;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
        GetTargetTransform();
        
    }

    void Update()
    {
        if(controller.isHiding)
        {
            //maybe add coroutine for length of hiding duration.
            GetTargetTransform();
            SetCameraTransform();
        } 
    }

    void GetTargetTransform()
    {
        target = controller.hideTarget;
        if(target == null) return;
    }

    void SetCameraTransform()
    {
        transform.position = target.transform.position;
        transform.rotation = target.transform.rotation; 
    }
}
