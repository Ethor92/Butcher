using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hideable : MonoBehaviour
{
    [SerializeField] float hideDistance = 5f;
    public bool isInRange = false;
    

    GameObject player;
    

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, hideDistance);
    }

    void Update()
    {
        IsInRange();
    }

    private void IsInRange()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if(distanceToPlayer < hideDistance){
            isInRange = true;
        }
        else{
            isInRange = false;
        }
        
    }

    
}
