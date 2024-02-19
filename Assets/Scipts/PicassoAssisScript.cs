using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicassoAssis : MonoBehaviour
{
    public GameObject panel;
    public GameObject canvas;

    public void Start()
    {
        panel.transform.position = canvas.transform.position;
        panel.transform.localScale = new Vector3(1, 1, 1);
        panel.SetActive(false);
    }

    public void OpenPanel()
    {
        if (panel == null) return;
        panel.SetActive(true);
    }

    public void ClosePanel()
    {
        if (panel == null) return;
        panel.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OpenPanel();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ClosePanel();
        }
    }
}
