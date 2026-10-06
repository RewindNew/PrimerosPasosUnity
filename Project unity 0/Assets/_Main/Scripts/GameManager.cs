using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int _puntosVidaActuales = 100;
    [SerializeField] private GameObject _panelOfDeath;
    [SerializeField] private PlayerStats _playerStats;

    private void Start()
    {
        ReanudarElJuego();
    }

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


  

}
