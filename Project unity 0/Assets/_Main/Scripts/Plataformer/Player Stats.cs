
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVidaActuales = 100;
    [SerializeField] private int _puntosVidaMaximo = 100;
    [SerializeField] private UIManager _uiManager;

    public void RestarVida(int daño)
    {
        _puntosVidaActuales = _puntosVidaActuales - daño;

    }

    public void SumarVida(int curar)
    {
        _puntosVidaActuales = _puntosVidaActuales + curar;

        if (_puntosVidaActuales > _puntosVidaMaximo)
        {
            _puntosVidaActuales = _puntosVidaMaximo;
        }

    }



    private void Update()
    {
        if (_puntosVidaActuales >= 80)
        {
            _uiManager.ColorBarra(new Color(68f / 255f, 189f / 255f, 68f / 255f));
        }
        if (40 <= _puntosVidaActuales && _puntosVidaActuales < 80)
        {
            _uiManager.ColorBarra(new Color(255f / 255f, 73f / 255f, 39f / 255f, 255f / 255f));

        }
        if (_puntosVidaActuales < 40)
        {
            _uiManager.ColorBarra(new Color(189f / 255f, 15f / 255f, 15f / 255f, 255f / 255f));
        }
        
        if (_puntosVidaActuales <= 0)
        {
            Destroy(this.gameObject);
        }

    }



}
