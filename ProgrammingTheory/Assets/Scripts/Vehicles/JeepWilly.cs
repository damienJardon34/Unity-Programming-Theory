using UnityEngine;

public class JeepWilly : Vehicle // INHERITANCE
{
    // Update is called once per frame
    new void Update() // POLYMORHISM
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

