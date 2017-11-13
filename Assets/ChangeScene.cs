/////////////////////////////////////////////////
//                  CREATE                      
//Author:       Grzegorz Jaruszewski
//Date:         2017-11-12
//Description:  Obracanie obiektu
/////////////////////////////////////////////////
//                  CHANGE                      
//Author:
//Date:
//Description:
/////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

	// Update is called once per frame
	public void ChangeToScene (string sceneToChangeTo) {
        Application.LoadLevel(sceneToChangeTo);
	}
}
