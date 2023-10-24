using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    private int hats = 0;

    [SerializeField] private Text ScoreCounter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hat"))
        {
            Destroy(collision.gameObject);
            hats++;
            ScoreCounter.text = "Hats: " + hats;
        }
    }
}
