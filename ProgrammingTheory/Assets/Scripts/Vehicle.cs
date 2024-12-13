using NUnit.Framework.Constraints;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] float _speed = 10f;
    [SerializeField] float _reverseSpeed = 10f;
    [SerializeField] float _turnSpeed = 100f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
     protected void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        Turn(direction);

        float accelerator = Input.GetAxis("Vertical");
        if (accelerator > 0)
        {
            MoveForward(accelerator);
        }
        else if (accelerator < 0)
        {
            MoveBackward(accelerator);
        }
    }


    public void Turn(float direction)
    {
        transform.Rotate(Vector3.up, direction * Time.deltaTime * _turnSpeed);
    }

    public void MoveForward(float accelerator)
    {
        transform.Translate(Vector3.forward * accelerator * Time.deltaTime * _speed);
    }

    public void MoveBackward(float accelerator)
    {
        transform.Translate(Vector3.forward * accelerator * Time.deltaTime * _reverseSpeed);
    }
}
