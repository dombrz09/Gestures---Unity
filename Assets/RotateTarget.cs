/////////////////////////////////////////////////
//                  CREATE                      
//Author:       Dominika Brzozowska
//Date:         2017-10-22
//Description:  Rotate object in 3D
/////////////////////////////////////////////////
//                  CHANGE                      
//Author:
//Date:
//Description:
/////////////////////////////////////////////////

using UnityEngine;


public class RotateTarget : MonoBehaviour
{
    //Cube (target)
    public GameObject target = null;

    //Speed
    float mouseSpeed = 20;

    // Use this for initialization
    void Start(){}

    // Rotate target
    void Update()
    {
        //Check right mouse button click and target
       if(Input.GetMouseButtonDown(1) && target != null) 
            moveCamera();      
    }


    //Calculate rotation
    void moveCamera()
    {
        transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime * 20);
    }
}