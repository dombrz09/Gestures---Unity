/////////////////////////////////////////////////
//                  CREATE                      
//Author:       Dominika Brzozowska
//Date:         2017-12-03
//Description:  Czyszcenie obiektów
/////////////////////////////////////////////////
//                  CHANGE                      
//Author:       
//Date:         
//Description:  
/////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearObject : MonoBehaviour {

    private bool check_status;

    void OnMouseDrag()
    {
        if (check_status == true)
        Destroy(gameObject);
    }

   public void clear_object()
    {
        check_status = true;
    }

    public void stop_clearing()
    {
        check_status = false;
    }

   public void reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
