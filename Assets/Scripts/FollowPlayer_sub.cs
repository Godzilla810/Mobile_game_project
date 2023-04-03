using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer_sub : MonoBehaviour
{
    public GameObject player;   //添加可變物件,變數型態:GameObject
    private Vector3 offset = new Vector3(0 ,2.2f ,-0.2f);//變數型態:Vector3

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()   //LateUpadate:先移動在更新
    {
        transform.position = player.transform.position + offset ;
        transform.rotation = player.transform.rotation ;
    }
}
