using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPowerUp : MonoBehaviour {

    Transform[] PowerUps;

	// Use this for initialization
	void Start () {
        PowerUps = new Transform[3];
        int indice = 0;
        foreach (Transform child in transform)
        {
            PowerUps[indice] = child;
            indice++;
        }
        InvokeRepeating("GenerarPowerUp", 10, 10);
        
    }
	
    private void GenerarPowerUp()
    {
        int numeroArrayAletorio = Random.Range(0, PowerUps.Length);

        PowerUps[numeroArrayAletorio].position = new Vector3(Random.Range(-7f, 7f), Random.Range(-4, 4) , PowerUps[numeroArrayAletorio].position.z);
    }
	
}
