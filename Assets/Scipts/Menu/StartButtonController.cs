using UnityEngine;

public class StartButtonController : MonoBehaviour
{
    public GameObject panelToShow; 
    private bool isPanelActive = false; 

    private void Update()
    {
        
        if (Input.GetButtonDown("StartButton"))
        {
            TogglePanel(); 
        }
    }

    private void TogglePanel()
    {
        isPanelActive = !isPanelActive; 

        
        panelToShow.SetActive(isPanelActive);
    }
}
