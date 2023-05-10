using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using StarterAssets;

public class CinemachineSwitcher : MonoBehaviour
{
   [SerializeField] private InputAction action;
  
   FirstPersonController player;
   private bool playerCam = true;
   
   private Animator animator;

   private void Awake()
   {
    animator = GetComponent<Animator>();
   }

   void Start(){
    player = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
    action.performed += _ => SwitchState();
    
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
    if(!player.GetCanHide())return;
        if(playerCam)
        {
            animator.Play("player cam");
        }
        else{
            animator.Play("hide cam");
            print("you are hiding");
        }
        playerCam = !playerCam;
   }

   public bool CurrentCam()
   {
    return playerCam;
   }
}
