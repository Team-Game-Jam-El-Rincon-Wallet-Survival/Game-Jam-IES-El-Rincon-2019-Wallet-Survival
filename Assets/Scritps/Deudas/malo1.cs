using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class malo1 : MonoBehaviour {

    public GameObject cartera;
    public float speed;
    public Text textoDinero;
    public Text textoDinero2;
    public bool player1invulneravilidad;
    public bool player2invulneravilidad;



    // Use this for initialization
    void Start () {
        player1invulneravilidad = false;
        player2invulneravilidad = false;
    }
	
	// Update is called once per frame
	void Update () {
        

	}

    private void FixedUpdate()

    {
        transform.position = Vector3.MoveTowards(transform.position, cartera.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!player1invulneravilidad)
            {
                float dinero;
                if (gameObject.tag == "Steam")
                {
                   dinero = float.Parse(textoDinero.text) - 1;
                } else if (gameObject.tag == "HappyMeal")
                {
                   dinero = float.Parse(textoDinero.text) - 2;
                } else if (gameObject.tag == "TripleA")
                {
                   dinero = float.Parse(textoDinero.text) - 5;
                } else if (gameObject.tag == "Hacienda")
                {
                   dinero = float.Parse(textoDinero.text) - 8;
                } else {
                   dinero = float.Parse(textoDinero.text) - 10;
                }
                if (dinero <= 0)
                {
                    SceneManager.LoadScene("Victory2", LoadSceneMode.Single);
                }
                textoDinero.text = dinero + "";
            }

            float positionRandomX;
            float positionRandomY;
            if (Random.Range(0f,100f) > 50)
            {
                if (Random.Range(0f,100f) > 50)
                {
                    positionRandomX = 9f;
                } else {
                    positionRandomX = -9f;
                }
            } else
            {
                positionRandomX = Random.Range(-7f, 7f);
            }

            if (positionRandomX > 8 | positionRandomX < -8)
            {
                positionRandomY = Random.Range(-4f,4f);
            }
            else
            {
                if (Random.Range(0f, 100f) > 50)
                {
                    positionRandomY = 6f;
                }
                else
                {
                    positionRandomY = -6f;
                }
            }

            transform.position = new Vector3(positionRandomX, positionRandomY, transform.position.z);
            
            
        }

        if (collision.gameObject.tag == "Player2")
        {
            if (!player2invulneravilidad)
            {
                float dinero;
                if (gameObject.tag == "Steam")
                {
                    dinero = float.Parse(textoDinero2.text) - 1;
                }
                else if (gameObject.tag == "HappyMeal")
                {
                    dinero = float.Parse(textoDinero2.text) - 2;
                }
                else if (gameObject.tag == "TripleA")
                {
                    dinero = float.Parse(textoDinero2.text) - 5;
                }
                else if (gameObject.tag == "Hacienda")
                {
                    dinero = float.Parse(textoDinero2.text) - 8;
                }
                else
                {
                    dinero = float.Parse(textoDinero2.text) - 10;
                }
                if (dinero <= 0)
                {
                    SceneManager.LoadScene("Victory1", LoadSceneMode.Single);
                }

                textoDinero2.text = dinero + "";
            }

            float positionRandomX;
            float positionRandomY;
            if (Random.Range(0f, 100f) > 50)
            {
                if (Random.Range(0f, 100f) > 50)
                {
                    positionRandomX = 9f;
                }
                else
                {
                    positionRandomX = -9f;
                }
            }
            else
            {
                positionRandomX = Random.Range(-7f, 7f);
            }

            if (positionRandomX > 8 | positionRandomX < -8)
            {
                positionRandomY = Random.Range(-4f, 4f);
            }
            else
            {
                if (Random.Range(0f, 100f) > 50)
                {
                    positionRandomY = 6f;
                }
                else
                {
                    positionRandomY = -6f;
                }
            }

            transform.position = new Vector3(positionRandomX, positionRandomY, transform.position.z);
        }

        
    }

}
