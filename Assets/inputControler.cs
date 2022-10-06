using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputControler : MonoBehaviour
{
    [Space]
    [Header("Game Element")]
    [SerializeField] Rigidbody2D player;

    int gravity;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            if (player.gravityScale == 2)
            {
                player.gravityScale = -2;
            }
            else 
            {
                player.gravityScale = 2;
            }
        }       
    }
}
