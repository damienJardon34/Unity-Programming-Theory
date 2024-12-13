using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class PlaygroundController : MonoBehaviour
{
    [SerializeField] GameObject[] vehiclesPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (MainController.Instance.SelectedVehicle)
        {
            case MainController.VehicleType.JeepWilly:
                Instantiate(vehiclesPrefabs[0], vehiclesPrefabs[0].transform.position, vehiclesPrefabs[0].transform.rotation);
                break;
                case MainController.VehicleType.Tank:
                Instantiate(vehiclesPrefabs[1],  vehiclesPrefabs[1].transform.position, vehiclesPrefabs[1].transform.rotation);
                break;
            default:
                Debug.Log("Unknown vehicle selected");
                break;
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
