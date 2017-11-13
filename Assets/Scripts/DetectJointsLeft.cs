/////////////////////////////////////////////////
//                  CREATE                      
//Author:       Dawid Sklorz
//Date:         2017-11-11
//Description:  Detect left hand
/////////////////////////////////////////////////
//                  CHANGE                      
//Author:
//Date:
//Description:
/////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Windows.Kinect;
using UnityEngine.UI;
using System;

public class DetectJointsLeft : MonoBehaviour {

    public GameObject BodySrcManager;
    public JointType TrackedJoint;
    private BodySourceManager bodyManager;
    public Body[] bodies;
    public float multiplier = 15f;
    public float x, y, z;
    public GameObject Hand;

    // Use this for initialization
    void Start()
    {
        if (BodySrcManager == null)
        {
            Debug.Log("Assign GameObject with Body Source Manager");
        }
        else
        {
            bodyManager = BodySrcManager.GetComponent<BodySourceManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (bodyManager == null)
        {
            return;
        }
        this.bodies = bodyManager.GetData();
        if (this.bodies == null)
        {
            return;
        }
        foreach (var body in this.bodies)
        {
            if (body == null)
            {
                continue;
            }
            if (body.IsTracked)
            {
                var pos = body.Joints[TrackedJoint].Position;
                this.x = pos.X;
                this.y = pos.Y;
                this.z = pos.Z;

                //Zmiana pozycji obiektu
                gameObject.transform.position = new Vector3(pos.X * multiplier, pos.Y * multiplier, pos.Z * multiplier / 2);
            }
        }
    }

    //Pobieranie współrzędnych lewej ręki
    public float getLeftHandPositionX()
    {
        return this.x;
    }
    public float getLeftHandPositionY()
    {
        return this.y;
    }
    public float getLeftHandPositionZ()
    {
        return this.z;
    }
}
