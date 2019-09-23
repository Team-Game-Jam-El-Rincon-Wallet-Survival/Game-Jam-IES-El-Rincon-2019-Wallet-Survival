using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToInstructino : MonoBehaviour {
    

    public void SceneChange()
    {
        
            SceneManager.LoadScene("Instructions", LoadSceneMode.Single);
    }
}
