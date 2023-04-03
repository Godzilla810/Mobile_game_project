using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variable setting
    private float speed = 20.0f ;       
    private float turnSpeed = 25.0f ;
    private float horizontalInput ;   
    private float verticalInput ;
    
    public Camera Main_Camera ;
    public Camera Sub_Camera ;
    public KeyCode SwitchKey ;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get Input
        horizontalInput = Input.GetAxis("Horizontal") ;
        verticalInput = Input.GetAxis("Vertical") ;

        //Move
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput) ;
        //Turn
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput) ;

        if (Input.GetKeyDown(SwitchKey)){
            Main_Camera.enabled = !Main_Camera.enabled ;
            Sub_Camera.enabled = !Sub_Camera.enabled ;
        }

    }
}
