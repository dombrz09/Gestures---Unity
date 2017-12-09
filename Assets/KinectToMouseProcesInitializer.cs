/////////////////////////////////////////////////
//                  CREATE                      
//Author:       Piotr Arent
//Date:         2017-11-21
//Description:  Klasa tworzaca proces sterujacy kursorem za pomoca kinecta
/////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class KinectToMouseProcesInitializer : MonoBehaviour {

    static Process process = null;
        string fileName = "KinectV2MouseControl.exe";

    public void OnClickInitOrStop()
    {
 
        if (process == null || process.HasExited)
        {
            process = new Process();
            process.StartInfo.FileName = fileName;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.Start();
        }
        else
        {
            process.Kill();
        }
    }

    void OnClickStop()
    {
        
    }

    private void OnDestroy()
    {
        if (process != null && !process.HasExited)
            process.Kill();
    }
}
