using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuController : MonoBehaviour
{

    public void tryJeepWilly()
    {
        MainController.Instance.SelectedVehicle = MainController.VehicleType.JeepWilly;
        SceneManager.LoadScene(1);
    }

    public void tryTank()
    {
        MainController.Instance.SelectedVehicle = MainController.VehicleType.Tank;
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif
    }

}
