using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    [Space]
    [Header("UI Elements")]
    [SerializeField] Button StartGame;
    [SerializeField] GameObject UIStartContener;


    [Space]
    [SerializeField] Player player;
    [SerializeField] inputControler inputControler;
    private void Awake()
    {
        StartGame.onClick.AddListener(() => 
        {
            player.isMove = true;
            UIStartContener.SetActive(false);
            inputControler.isInput = true;
            player.gameObject.GetComponent<Rigidbody2D>().gravityScale = 3;
        });
    }

}
