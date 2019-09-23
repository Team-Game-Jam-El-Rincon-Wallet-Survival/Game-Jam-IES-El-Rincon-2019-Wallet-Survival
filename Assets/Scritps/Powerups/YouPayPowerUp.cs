using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouPayPowerUp : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject deuda1;
    public GameObject deuda2;
    public float secChangeObtjective;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            malo1[] deudas1 = deuda1.GetComponentsInChildren<malo1>();
            for (int i = 0; i < deudas1.Length; i++)
            {
                deudas1[i].cartera = player2;
            }
            transform.position = new Vector3(14f, -3, transform.position.z);
            Invoke("CambiarObjetivoPlayer1", secChangeObtjective);
        }
        else if (collision.gameObject.tag == "Player2")
        {
            malo1[] deudas2 = deuda2.GetComponentsInChildren<malo1>();
            for (int i = 0; i < deudas2.Length; i++)
            {
                deudas2[i].cartera = player1;
            }
            transform.position = new Vector3(14f, -3, transform.position.z);
            Invoke("CambiarObjetivoPlayer2", secChangeObtjective);
        }


    }

    private void CambiarObjetivoPlayer1 ()
    {
        malo1[] deudas1 = deuda1.GetComponentsInChildren<malo1>();
        for (int i = 0; i < deudas1.Length; i++)
        {
            deudas1[i].cartera = player1;
        }
    }

    private void CambiarObjetivoPlayer2()
    {
        malo1[] deudas2 = deuda2.GetComponentsInChildren<malo1>();
        for (int i = 0; i < deudas2.Length; i++)
        {
            deudas2[i].cartera = player2;
        }
    }
}
