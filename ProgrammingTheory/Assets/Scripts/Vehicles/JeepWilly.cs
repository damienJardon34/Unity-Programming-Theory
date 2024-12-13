using UnityEngine;

public class JeepWilly : Vehicle
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        float accelerator = Input.GetAxis("Vertical");
        if (accelerator > 0)
        {
            MoveForward(accelerator);
            Turn(direction);
        }
        else if (accelerator < 0)
        {
            MoveBackward(accelerator);
            Turn(direction * 1.5f);
        }
    }
}

