using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bal : MonoBehaviour
{
    [SerializeField] private GameObject lose;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            lose.SetActive(true);
            Time.timeScale = 1f;
        }
    }
}
