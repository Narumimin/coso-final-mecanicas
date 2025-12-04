using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private bool canvasControlesActivo = false;
    private bool canvasCreditosActivo = false;
    public GameObject canvasControles;
    public GameObject canvasMenu;
    public GameObject canvasCreditos;

    public void LoadNextScene()
    {
        SceneManager.LoadScene("VNDay1");
    }

    public void ToggleControles()
    {
        canvasControlesActivo = !canvasControlesActivo;

        if (canvasControles != null)
        {
            canvasControles.SetActive(canvasControlesActivo);
            canvasMenu.SetActive(!canvasControlesActivo);
        }
    }
    public void ToggleCreditos()
    {
        canvasCreditosActivo = !canvasCreditosActivo;

        if (canvasCreditos != null)
        {
            canvasCreditos.SetActive(canvasCreditosActivo);
            canvasMenu.SetActive(!canvasCreditosActivo);
        }
    }
    public void Salir()
    {
        Application.Quit();

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
    }
}
