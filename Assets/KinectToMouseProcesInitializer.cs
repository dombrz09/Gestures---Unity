/////////////////////////////////////////////////
//                  CREATE                      
//Author:       Piotr Arent
//Date:         2017-11-21
//Description:  Klasa tworzaca proces sterujacy kursorem za pomoca kinecta
/////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class KinectToMouseProcesInitializer : MonoBehaviour {

    Thread kinectToMouseThread = new Thread(KinectToMouse);
    static int Guard = 0;
    
    static void KinectToMouse()
    {
        Debug.Log("proces dziala");

        string fileName = "KinectV2MouseControl.exe";

        System.Diagnostics.Process.Start("KinectV2MouseControl.exe");
    }

    // Metoda wywowyławana przy naciśnięciu przycisku. Zajmuje się startowaniem wątku który wywołuje metode KinectToMouse.
    public void OnClickInitOrStop()
    {
        if(kinectToMouseThread.Name == null)
        {
            kinectToMouseThread.Name = "Kinect To Mouse Proces";
        }
        if (Guard == 0)
        {
            kinectToMouseThread.Start();
            kinectToMouseThread.IsBackground = true;
            Debug.Log("watek stworzony");

            Guard = 1;
        }
        else
        if(Guard == 1)
        {
            kinectToMouseThread = new Thread(KinectToMouse);
            GC.Collect();

            Debug.Log("watek zatrzymany");

            Guard = 0;
        }
    }

    void OnClickStop()
    {
        
    }

    private void OnDestroy()
    {
        kinectToMouseThread.Abort();
    }
}
