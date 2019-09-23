using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GotoCredits : MonoBehaviour {

	public void SceneChange()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }
}
