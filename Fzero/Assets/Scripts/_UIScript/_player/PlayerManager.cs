using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private CharacterController c_player;
    private Vector3 v;
    private float ho;
    private float ve;
    private void Start()
    {
        c_player = transform.GetComponent<CharacterController>();
        
    }
    private void FixedUpdate()
    {
        ho = Input.GetAxis("Horizontal");
        ve = Input.GetAxis("Vertical");
            v = new Vector3(ho, 0, ve);
        transform.Translate(v*7*Time.deltaTime,Space.World);
    }
}
