using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartController : MonoBehaviour {

    public enum GameSate {Idle, Playing }
    public GameSate gameState = GameSate.Idle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if( gameState == GameSate.Idle && (Input.GetKey(KeyCode.Space)))
        {
            Debug.Log("ta bien");
            gameState = GameSate.Playing;
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

        }
	}
}
