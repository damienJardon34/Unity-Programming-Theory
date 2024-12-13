using UnityEngine;

public class MainController : MonoBehaviour
{
    public static MainController Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public enum VehicleType
    {
        JeepWilly,
        Tank
    }

    public VehicleType SelectedVehicle;
}
