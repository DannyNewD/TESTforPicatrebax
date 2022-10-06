using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputControler : MonoBehaviour
{
    [Space]
    [Header("Game Element")]
    [SerializeField] Rigidbody2D player;

    [Space]
    [SerializeField] public bool isInput = false;

    int gravity;
    
    // Update is called once per frame
    void Update()
    {
        if (isInput) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (player.gravityScale == 3)
                {
                    player.gravityScale = -3;
                }
                else
                {
                    player.gravityScale = 3;
                }
            }
        }
    }
}
