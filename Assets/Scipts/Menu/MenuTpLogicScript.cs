using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTpLogicScript : MonoBehaviour
{
    public void TpToComporary()
    {
        var player = GameObject.Find("XR Origin (XR Rig)");
        player.transform.position = new Vector3((float)8.54, player.transform.position.y , (float)-22.48); 
    }
    
    public void TpToWorld()
    {
        var player = GameObject.Find("XR Origin (XR Rig)");
        player.transform.position = new Vector3((float)9.39, player.transform.position.y , (float)-3.53); 
    }
    
    public void TpToModern()
    {
        var player = GameObject.Find("XR Origin (XR Rig)");
        player.transform.position = new Vector3((float)30.43, player.transform.position.y , 16); 
    }
    
    public void TpToGreek()
    {
        var player = GameObject.Find("XR Origin (XR Rig)");
        player.transform.position = new Vector3((float)30.43, player.transform.position.y , (float)-22.48); 
    }
    
    public void TpToEgypt()
    {
        var player = GameObject.Find("XR Origin (XR Rig)");
        player.transform.position = new Vector3((float)9.39, player.transform.position.y , (float)15.35); 
    }
}
