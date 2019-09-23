using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpInvisible : MonoBehaviour {


    public GameObject player1;
    public GameObject player2;
    public float secInvisible;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player2.GetComponent<SpriteRenderer>().enabled = false;
            transform.position = new Vector3(14f, -3, transform.position.z);
            Invoke("AnularInvisivilidadPlayer2",secInvisible);
        } else if (collision.gameObject.tag == "Player2")
        {
            player1.GetComponent<SpriteRenderer>().enabled = false;
            transform.position = new Vector3(14f,-3,transform.position.z);
            Invoke("AnularInvisivilidadPlayer1", secInvisible);
        }


    }


    private void AnularInvisivilidadPlayer2()
    {
        player2.GetComponent<SpriteRenderer>().enabled = true;
    }

    private void AnularInvisivilidadPlayer1()
    {
        player1.GetComponent<SpriteRenderer>().enabled = true;
    }
}
