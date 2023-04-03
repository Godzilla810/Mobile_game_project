using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    //Variable setting
    private float speed = 20.0f ;       
    private float turnSpeed = 25.0f ;
    private float horizontalInput ;   
    private float verticalInput ;
    
    public Camera Main_Camera2 ;
    public Camera Sub_Camera2 ;
    public KeyCode SwitchKey2 ;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get Input
        horizontalInput = Input.GetAxis("Horizontal2") ;
        verticalInput = Input.GetAxis("Vertical2") ;

        //Move
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput) ;
        //Turn
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput) ;

        if (Input.GetKeyDown(SwitchKey2)){
            Main_Camera2.enabled = !Main_Camera2.enabled ;
            Sub_Camera2.enabled = !Sub_Camera2.enabled ;
        }

    }
}
