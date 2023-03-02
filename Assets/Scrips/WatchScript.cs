using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchScript : MonoBehaviour
{
    //Attach the Watch Cavas here in the editor
    public GameObject WatchUI;

    private bool Show = false;

    // Start is called before the first frame update
    void Start()
    {
        //Set to hide UI by default. This way it can still be visible in the editor for easy editing
        WatchUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Get button inputs, watch for the left controller "X" button
        if(OVRInput.GetDown(OVRInput.Button.Three))
        {
            Debug.Log("X button was pressed");
            ToggleUI();
            

        }
        
     
    }

    void ToggleUI()
    {
        if (!Show)
        {
            WatchUI.SetActive(true);
            Show = true;
        }
        else
        {
            WatchUI.SetActive(false);
            Show = false;
        }
    }
    
}
