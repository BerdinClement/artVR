using UnityEngine;
using UnityEngine.UI;

public class StartButtonController : MonoBehaviour
{
    public GameObject selectionPanel; 
    public Button startButton; 

    private bool panelActive = false; 

    private void Start()
    {
        startButton.onClick.AddListener(TogglePanel);
    }

    void TogglePanel()
    {
        panelActive = !panelActive; 

        
        selectionPanel.SetActive(panelActive);
    }
}
