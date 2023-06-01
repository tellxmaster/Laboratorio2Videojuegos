using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // necesario para recargar la escena

public class ChestController : MonoBehaviour
{
    public GameObject wins;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (wins.activeSelf && Input.GetKeyDown(KeyCode.R)) // si wins está activo y se presiona la tecla R
        {
            Time.timeScale = 1; // resetea la velocidad de tiempo
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // recarga la escena
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            wins.SetActive(true);
            Time.timeScale = 0; // pausa el juego
        }
    }
}
