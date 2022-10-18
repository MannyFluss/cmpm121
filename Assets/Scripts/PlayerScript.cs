using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //script credit https://www.youtube.com/watch?v=J6QR4KzNeJU&t=1s&ab_channel=gamesplusjames 
    public float forwardSpeed = 100f, strafeSpeed = 100f, hoverSpeed = 100f;
    private float activeForwardSpeed, activeStrafeSpeed, activeHoverSpeed;
    private float forwardAcceleration = 75f, strafeAcceleration = 75f, hoverAcceleration = 75f;
   
    private float rollInput;
    public float rollspeed = 90f, rollAcceleration = 3.5f;
    public float lookRateSpeed = 90f;
    private Vector2 lookInput, screenCenter, mouseDistance;
    // Start is called before the first frame update
    void Start()
    {
        screenCenter.x = Screen.width * .5f;
        screenCenter.y = Screen.height * .5f;

    }
    void Update()
    {
        lookInput.x = Input.mousePosition.x;
        lookInput.y = Input.mousePosition.y;


        mouseDistance.x = (lookInput.x - screenCenter.x) / screenCenter.y;
        mouseDistance.y = (lookInput.y - screenCenter.y) / screenCenter.y;

        mouseDistance = Vector2.ClampMagnitude(mouseDistance,1f);

        transform.Rotate(new Vector3(-mouseDistance.y * lookRateSpeed * Time.deltaTime, 
            mouseDistance.x * lookRateSpeed * Time.deltaTime, rollInput*rollspeed * Time.deltaTime ), Space.Self);

        activeForwardSpeed = Mathf.Lerp (activeForwardSpeed, Input.GetAxisRaw("Vertical") * forwardSpeed, forwardAcceleration * Time.deltaTime);
        activeStrafeSpeed = Mathf.Lerp (activeStrafeSpeed, Input.GetAxisRaw("Horizontal") * strafeSpeed, strafeAcceleration * Time.deltaTime);
        activeHoverSpeed =  Mathf.Lerp (activeHoverSpeed, Input.GetAxisRaw("Horizontal") * hoverSpeed, hoverAcceleration * Time.deltaTime);
        rollInput = Mathf.Lerp(rollInput,Input.GetAxisRaw("Roll"),rollAcceleration * Time.deltaTime);

        transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;
        transform.position += (transform.right * activeStrafeSpeed * Time.deltaTime) + (transform.up * activeHoverSpeed * Time.deltaTime);
      //  print(transform.position);
    }

    // Update i
}
