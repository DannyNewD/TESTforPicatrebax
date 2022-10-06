using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] bool isMove;
    [SerializeField] float speed;
    [SerializeField] Vector3 diraction;   

    private void FixedUpdate()
    {
        if (isMove)
            transform.Translate(diraction.normalized * speed);
    }
}
