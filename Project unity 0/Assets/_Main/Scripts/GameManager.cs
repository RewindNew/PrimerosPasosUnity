using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _puntosVidaActuales = 100;
    [SerializeField] private GameObject _panelOfDeath;

    public void CargarEscena(int scene)
    {
        SceneManager.LoadScene(scene);
    }


    public void SalirDelJuego()
    {
        Application.Quit();
    }
    
    public void PausarElJuego()
    {
        Time.timeScale = 0; 
    }

    public void ReanudarElJuego()
    {
        Time.timeScale = 1;
    }


    public void LoadgameObject()
    {
        if (_puntosVidaActuales <= 0)
        {
            _panelOfDeath.SetActive(true);
        }
    }

}
