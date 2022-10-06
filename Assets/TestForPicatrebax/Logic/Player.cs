using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    /////////////////
    //  Я розумію, що треба розділяти UI архітектуру та плеєра. Зробив тут, тому що це концепт та є обмеження в часі.
    /////////////////

    [Space]
    [Header("Move")]
    [SerializeField] public bool isMove;
    [SerializeField] float speed;
    [SerializeField] Vector3 diraction;

    [Space]
    [Header("GameConfig")]
    [SerializeField] float top;
    [SerializeField] float bottom;

    [Space]
    [Header("UI")]
    [SerializeField] Text TextScore;
    int score;


    private void FixedUpdate()
    {
        if (isMove) 
        { 
            transform.Translate(diraction * speed);
        } 

        if (gameObject.transform.localPosition.y > top || gameObject.transform.localPosition.y < bottom)
        {
            RestartGame();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        score++;
        TextScore.text = "SCORE: " + score;
    }
}
