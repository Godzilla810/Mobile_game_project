using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    //Variable setting
    private float speed = 20.0f ;       
    private float turnSpeed = 25.0f ;
    private float horizontalInput ;   
    private float verticalInput ;
    
    public Camera Main_Camera1 ;
    public Camera Sub_Camera1 ;
    public KeyCode SwitchKey1 ;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get Input
        horizontalInput = Input.GetAxis("Horizontal1") ;
        verticalInput = Input.GetAxis("Vertical1") ;

        //Move
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput) ;
        //Turn
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput) ;

        if (Input.GetKeyDown(SwitchKey1)){
            Main_Camera1.enabled = !Main_Camera1.enabled ;
            Sub_Camera1.enabled = !Sub_Camera1.enabled ;
        }

    }
}
