using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using StarterAssets;

public class CinemachineSwitcher : MonoBehaviour
{
   [SerializeField] private InputAction action;
  
   FirstPersonController player;
   
   CapsuleCollider playerCollider;
   
   private bool playerCam = true;
   
   private Animator animator;

   private void Awake()
   {
    animator = GetComponent<Animator>();
   }

   void Start(){
    player = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
    playerCollider = GameObject.FindGameObjectWithTag("PlayerCollider").GetComponent<CapsuleCollider>();
    
    action.performed += _ => SwitchState();
    playerCam = true;
    
   }

   void Update()
   {
    
   }

   private void OnEnable() //on Input
   {
     action.Enable();
   }

   private void OnDisable()
   {
    action.Disable();
   }

   private void SwitchState()
   {
    
    if(!player.CanHide()) return;
    
        if(playerCam)
        {
            animator.Play("hide cam");
            print("you are hiding");
            player.enabled = false; //take away control of character until unhidden
            playerCollider.enabled = false;
            player.hideText.enabled = false;
        }

        else{

            animator.Play("player cam");
            player.enabled = true;
            playerCollider.enabled = true;
            
        }
        playerCam = !playerCam;
   }
}

