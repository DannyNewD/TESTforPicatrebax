using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] bool isMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
   

    private void FixedUpdate()
    {
        if (isMove)
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0.5f, 0, 0));
    }
}
