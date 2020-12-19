using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Public fields
    [Header("Public Settings (Please Modify)")]
    [SerializeField] private float moveSpeed = 3f;

    // Debug Public fields
    [Header("Debug Settings")]
    [SerializeField] private float acceleration = 1f;
    [SerializeField] private Vector3 currentVelocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Move the player
    void movePlayer() {

        int vInput = ((Input.GetKey(KeyCode.W)) ? 1 : 0) - ((Input.GetKey(KeyCode.S)) ? 1 : 0);
        int hInput = ((Input.GetKey(KeyCode.D)) ? 1 : 0) - ((Input.GetKey(KeyCode.A)) ? 1 : 0);

        Vector3 idealVector = new Vector3(hInput, 0, vInput).normalized; 

        transform.position = Vector3.SmoothDamp(transform.position, transform.position + (idealVector * moveSpeed), ref currentVelocity, acceleration, moveSpeed);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }
}
