using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if(transform.localPosition.x < Camera.main.gameObject.transform.localPosition.x - 20) 
        {
            Destroy(this.gameObject);
        }


    }
}
