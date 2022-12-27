using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private bool isHit = false;

    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI score2;

    private int scoreC;


    private void Update()
    {
        score.text = scoreC.ToString();
        score2.text = scoreC.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            if (isHit)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5f);
                scoreC++;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            isHit = false;
        }
    }

    public void Click()
    {
        isHit = true;
    }

    public void pause()
    {
        Time.timeScale = 1f;
    }
    public void Continue()
    {
        Time.timeScale = 0f;
    }
}
