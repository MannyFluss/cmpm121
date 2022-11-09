using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleLight : MonoBehaviour
{
    public Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("p"))
        {
            myLight.enabled = !myLight.enabled;
        
        }  
    }
}
