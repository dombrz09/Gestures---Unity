using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GestureRecognationInitializer : MonoBehaviour
{

    public void StartProcess()
    {
        string fileName = "D:\\Gestures---Unity\\NOWE_v1.2\\StartGestures\\StartGestures\\StartGestures\\bin\\Debug\\StartGestures.exe";

        Process process = new Process();
        process.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
        process.StartInfo.Arguments = "/k cd GesturesRecognation & cd bin & cd x86 & cd Debug & start /min GesturesRecognation.exe";
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
        process.Start();
    }

    public void KillProcess()
    {
        Process[] processes = Process.GetProcessesByName("GesturesRecognation");
        processes[0].Kill();
    }
}
