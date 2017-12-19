using UnityEngine;

public delegate void MouseMoved(float xMovement, float yMovement);
public class InputManager : MonoBehaviour
{
    #region Private References
    private float _xMovement;
    private float _yMovement;
    #endregion

    #region Events
    public static event MouseMoved MouseMoved;
    #endregion

    #region Event Invoker Methods
    private static void OnMouseMoved(float xmovement, float ymovement)
    {
        var handler = MouseMoved;
        if (handler != null) handler(xmovement, ymovement);
    }
    #endregion


    #region Private Methods
    private void InvokeActionOnInput()
    {
        if (true)
        {
            _xMovement = Input.GetAxis("Mouse X");
            _yMovement = Input.GetAxis("Mouse Y");
            OnMouseMoved(_xMovement, _yMovement);
        }
    }
    #endregion

    #region Unity CallBacks

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("WSZEDŁĘM TUTAJ");
            InvokeActionOnInput();
            print("XXXXXXXXXXXX");
        }
    }
    #endregion
}