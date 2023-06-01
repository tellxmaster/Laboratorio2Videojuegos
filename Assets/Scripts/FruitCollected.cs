using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            // obtener una referencia al script GameManager en alguna parte de tu juego
            // puedes ponerlo en un objeto de GameManager o algo similar
            GameManager gameManager = FindObjectOfType<GameManager>();

            // notificar al GameManager que se ha recogido una fruta
            gameManager.CollectFruit();

            Destroy(gameObject, 0.5f);
        }
    }
}
