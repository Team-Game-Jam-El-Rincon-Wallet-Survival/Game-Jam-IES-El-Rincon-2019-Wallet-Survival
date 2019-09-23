using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvensibilityPowerUp : MonoBehaviour {

    public GameObject deuda1;
    public GameObject deuda2;
    public float secInvulneravility;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.position = new Vector3(14f, -3, transform.position.z);
            malo1[] deudas1 = deuda1.GetComponentsInChildren<malo1>();
            malo1[] deudas2 = deuda2.GetComponentsInChildren<malo1>();

            for (int i = 0; i < deudas1.Length; i++)
            {
                deudas1[i].player1invulneravilidad = true;
            }

            for (int i = 0; i < deudas2.Length; i++)
            {
                deudas2[i].player1invulneravilidad = true;
            }
            Invoke("CambiarInvulneravilidadPlayer1", secInvulneravility);
        }
        else if (collision.gameObject.tag == "Player2")
        {
            transform.position = new Vector3(14f, -3, transform.position.z);
            malo1[] deudas1 = deuda1.GetComponentsInChildren<malo1>();
            malo1[] deudas2 = deuda2.GetComponentsInChildren<malo1>();

            for (int i = 0; i < deudas1.Length; i++)
            {
                deudas1[i].player2invulneravilidad = true;
            }

            for (int i = 0; i < deudas2.Length; i++)
            {
                deudas2[i].player2invulneravilidad = true;
            }

            Invoke("CambiarInvulneravilidadPlayer2", secInvulneravility);
        }
    }


    private void CambiarInvulneravilidadPlayer1()
    {
        malo1[] deudas1 = deuda1.GetComponentsInChildren<malo1>();
        malo1[] deudas2 = deuda2.GetComponentsInChildren<malo1>();

        for (int i = 0; i < deudas1.Length; i++)
        {
            deudas1[i].player1invulneravilidad = false;
        }

        for (int i = 0; i < deudas2.Length; i++)
        {
            deudas2[i].player1invulneravilidad = false;
        }
    }

    private void CambiarInvulneravilidadPlayer2()
    {
        malo1[] deudas1 = deuda1.GetComponentsInChildren<malo1>();
        malo1[] deudas2 = deuda2.GetComponentsInChildren<malo1>();

        for (int i = 0; i < deudas1.Length; i++)
        {
            deudas1[i].player2invulneravilidad = false;
        }

        for (int i = 0; i < deudas2.Length; i++)
        {
            deudas2[i].player2invulneravilidad = false;
        }
    }
}
