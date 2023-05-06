using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stealth", menuName = "Make Stealth Object", order = 0)]
public class HidingConfig : ScriptableObject
{
    [SerializeField] GameObject stealthObjectPrefab;
    [SerializeField] GameObject cameraConstraint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
