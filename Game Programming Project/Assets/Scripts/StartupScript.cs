using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupScript : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Awake()
    {
        Resolution[] resoultions = Screen.resolutions;
        Screen.SetResolution(1920,1080,true);
    }
}
