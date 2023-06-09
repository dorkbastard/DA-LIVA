using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DRIVER : MonoBehaviour
{

    [SerializeField] float steerSpeed = 1;
    [SerializeField] float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
       
    }
}
