using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorPanel : MonoBehaviour
{
    [Space]
    [Header("GameElement")]
    [SerializeField] GameObject panel;
    [SerializeField] Transform Contener;

    [SerializeField] GameObject basePanel;
    GameObject lastPanel;

    [SerializeField] float minOffset;
    [SerializeField] float maxOffset;

    [SerializeField] float minScale;
    [SerializeField] float maxScale;
    private void Start()
    {
        lastPanel = basePanel;
    }

    private void Update()
    {
        if (Camera.main.gameObject.transform.localPosition.x > lastPanel.transform.localPosition.x-20)
        {
            GameObject g = panel;
            Instantiate(g, Contener);
            g.transform.localScale = new Vector3(Random.Range(minScale, maxScale), 1, 1);
            g.transform.localPosition = new Vector3(
                lastPanel.transform.localPosition.x 
                + (lastPanel.transform.localScale.x / 2) + Random.Range(minOffset, maxOffset) + (g.transform.localScale.x/2),
                lastPanel.transform.localPosition.y,
                lastPanel.transform.localPosition.z);
           
            lastPanel = g;
        }
    }
}
