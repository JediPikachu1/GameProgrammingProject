using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupScript : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        Resolution[] resoultions = Screen.resolutions;
        Screen.SetResolution(1920,1080,true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
