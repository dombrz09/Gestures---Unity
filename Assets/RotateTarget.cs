/////////////////////////////////////////////////
//                  CREATE                      
//Author:       Dominika Brzozowska
//Date:         2017-10-22
//Description:  Obracanie obiektu
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
    private float speed = 100f;

    void Start() { }

    void Update()
    {

        //Sprawdzenie czy prawy przycisk myszy jest wciśniety
        if (((Input.touchCount > 0 && Input.GetTouch(1).phase == TouchPhase.Began) || Input.GetMouseButton(1)) && target != null)
            moveCamera();
    }


    //procedura sprawdzająca, która opcja obrotu ma zostać wykonana
    void moveCamera()
    {
        if (Input.GetAxis("Mouse X") > 0f) //kierunek : prawo
            transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime * speed);
        if (Input.GetAxis("Mouse X") < 0f) //kierunek : lewo
            transform.RotateAround(target.transform.position, Vector3.down, Time.deltaTime * speed);
        if (Input.GetAxis("Mouse Y") > 0f) //kierunek : góra
            transform.RotateAround(target.transform.position, Vector3.left, Time.deltaTime * speed);
        if (Input.GetAxis("Mouse Y") < 0f) //kierunek : dół
            transform.RotateAround(target.transform.position, Vector3.right, Time.deltaTime * speed);
    }
}