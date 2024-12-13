using UnityEngine;

public class Tank : Vehicle
{
    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        float accelerator = Input.GetAxis("Vertical");
   
        Turn((accelerator == 0)? direction * 1.3f : direction);

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
