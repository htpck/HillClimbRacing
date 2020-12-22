using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float fuel = 1;
    public float fuelconsumption = 100f;
    public Rigidbody2D carRigidBody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 20;
    public float carTorque = 10;
    public float movement;
    public UnityEngine.UI.Image image;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        image.fillAmount = fuel;
    }

    private void FixedUpdate()
    {
        if (fuel > 0)
        {
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            carRigidBody.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
        }
        fuel -= fuelconsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
        }
}
