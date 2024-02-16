using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SNOWARGENTEUILScript : MonoBehaviour
{
    
    public GameObject panel;

    public void Start()
    {
        panel.transform.position = new Vector3((float)-12.63, (float)1.26, (float)27.25);
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
