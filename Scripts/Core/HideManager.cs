using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideManager : MonoBehaviour
{
    [SerializeField] Transform hideConstraint;
    [SerializeField] Transform hideCam;
    [SerializeField] Transform playerCam;

    [SerializeField] CinemachineSwitcher switcher;

    [SerializeField] float raycastDistance = 10f;
    public LayerMask layerMask;

    void Start()
    {
       hideCam.transform.position = playerCam.transform.position;
       print(switcher.CurrentCam());
    }

    void Update()
    {
        
    }

    void OnHide()
    {

    }

    

    
}
