/////////////////////////////////////////////////
//                  CREATE                      
//Author:       Dominika Brzozowska
//Date:         2017-10-22
//Description:  Obracanie obiektu
/////////////////////////////////////////////////
//                  CHANGE                      
//Author:       Grzegorz Jaruszewski
//Date:         2017-11-20
//Description:  Zmiana sposobu działania kamery
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
    public GameObject target;


    //Speed
    private float speed = 10f;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;


    void Start() { }

    void Update()
    {

        //Sprawdzenie czy lewy przycisk myszy jest wciśniety
        if (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButton(0)) && target != null)
            moveCameraForward();

        //Sprawdzenie czy prawy przycisk myszy jest wciśniety
        if (((Input.touchCount > 0 && Input.GetTouch(1).phase == TouchPhase.Began) || Input.GetMouseButton(1)) && target != null)
            moveCameraBack();

        //Sprawdzenie czy środkowy przycisk myszy jest wciśniety
        if (((Input.touchCount > 0 && Input.GetTouch(2).phase == TouchPhase.Began) || Input.GetMouseButton(2)) && target != null)
            rotateCamera();
    }

    void rotateCamera()
    {
        /*
        if (Input.GetAxis("Mouse X") > 0f) //kierunek : prawo
            transform.RotateAround(target.transform.position, Vector3.down, Time.deltaTime * speed);
        if (Input.GetAxis("Mouse X") < 0f) //kierunek : lewo
            transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime * speed);
        if (Input.GetAxis("Mouse Y") > 0f) //kierunek : góra
            transform.RotateAround(target.transform.position, Vector3.right, Time.deltaTime * speed);
        if (Input.GetAxis("Mouse Y") < 0f) //kierunek : dół
            transform.RotateAround(target.transform.position, Vector3.left, Time.deltaTime * speed);
        */

            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

    void moveCameraForward()
    {
        transform.Translate(Vector3.forward / 10);
    }

    void moveCameraBack()
    {
        transform.Translate(Vector3.back / 10);
    }

    /*
    //poruszanie kamera po osiach XY
    void moveCameraXY()
    {
        if (Input.GetAxis("Mouse Y") > 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed, 0.0f);
        }

        else if (Input.GetAxis("Mouse Y") < 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed, 0.0f);
        }
    }

    //poruszanie kamera po osiach XZ
    void moveCameraXZ()
    {
        if (Input.GetAxis("Mouse X") > 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                       0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
        }

        else if (Input.GetAxis("Mouse X") < 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                       0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
        }
    }
    */
    //procedura sprawdzająca, która opcja obrotu ma zostać wykonana
}