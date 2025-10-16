using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void CargarNivel1()
    {
        Debug.Log("Botón 'Nivel 1' presionado. ¡Cargando escena del Nivel 1!");
        // SceneManager.LoadScene("Nivel1");
    }

    public void CargarNivel2()
    {
        Debug.Log("Botón 'Nivel 2' presionado. ¡Cargando escena del Nivel 2!");
        // SceneManager.LoadScene("Nivel2");
    }

    public void SalirAlLobby()
    {
        Debug.Log("Botón 'Salir al Lobby' presionado. ¡Volviendo al Lobby!");
        // SceneManager.LoadScene("Lobby");
    }
}