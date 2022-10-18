using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{

    private Vector3 moveBy = new Vector3(50,0,0);
    public float period = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += moveBy * Time.deltaTime;
        if (period > 10)
        {
            moveBy = -moveBy;
            //Do Stuff
            period = 0;
        }
        period += UnityEngine.Time.deltaTime;  
    }
}
