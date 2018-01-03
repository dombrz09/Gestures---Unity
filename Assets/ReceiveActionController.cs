using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveActionController : MonoBehaviour
{
    void Start()
    {
        this.Update();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.PageUp))
        {
            //System.IO.File.WriteAllText(@"C:\Users\Dawid\Desktop\testX.txt", "zoom IN!!!!!!!!!!!!");
        }
        else if (Input.GetKey(KeyCode.PageDown))
        {
            //System.IO.File.WriteAllText(@"C:\Users\Dawid\Desktop\testX.txt", "zoom OUT!!");
        }
    }
}
