using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    public GameObject menu;
    public InputActionProperty showMenu;

    // Update is called once per frame
    void Update()
    {
        if(showMenu.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
        }
    }
}
