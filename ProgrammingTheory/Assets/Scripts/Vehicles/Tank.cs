using UnityEngine;

public class Tank : Vehicle
{
    // Update is called once per frame
    new void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        float accelerator = Input.GetAxis("Vertical");
   
        Turn(direction); // can use differential steering to turn on the spot.

        if (accelerator > 0)
        {
            MoveForward(accelerator);
            
        }
        else if (accelerator < 0)
        {
            MoveBackward(accelerator);
            
        }
    }
}
