using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CinemachineSwitcher : MonoBehaviour
{
   [SerializeField] private InputAction action;
   private bool playerCam = true;
   [SerializeField] bool canHide = false;

   private Animator animator;

   private void Awake()
   {
    animator = GetComponent<Animator>();
   }

   private void OnEnable()
   {
     action.Enable();
   }

   private void OnDisable()
   {
    action.Disable();
   }

   void Start()
   {
    action.performed += _ => SwitchState();
   }

   private void SwitchState()
   {
        if(playerCam)
        {
            animator.Play("player cam");
        }
        else if(canHide){
            animator.Play("hide cam");
        }
        playerCam = !playerCam;
   }

   public bool CurrentCam()
   {
    return playerCam;
   }
}
