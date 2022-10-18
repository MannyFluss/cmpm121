using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    Vector3 centerPoint = new Vector3(0,0,0);
    [SerializeField] Vector3 rotateVector = Vector3.up;
    [SerializeField] int rotationSpeed = 30;
    private int selfRotate = 10;
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.Range(1,3);
        selfRotate = Random.Range(4,20);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(centerPoint, rotateVector, rotationSpeed * Time.deltaTime);
        this.transform.Rotate(new Vector3(0,selfRotate,0) *Time.deltaTime);
    }
}
