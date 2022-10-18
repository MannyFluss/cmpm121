using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject[] cams;
    private int curr = -1;
    // Update is called once per frame
    void Start()
    {
        nextCamera();
    }
    void Update()
    {
        if (Input.GetButtonDown("n"))
        {
            nextCamera();
        }
    }
    void nextCamera()
    {
        curr = (curr+1)%cams.Length;
        for (int i = 0; i< cams.Length; i++)
        {
            if (i != curr)
            {
                cams[i].SetActive(false);
                continue;
            }
            cams[i].SetActive(true);
        }
    }
}
