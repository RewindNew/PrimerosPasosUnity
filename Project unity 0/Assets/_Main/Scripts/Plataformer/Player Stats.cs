using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVIda = 100;
    [SerializeField] private Image _barra;
    [SerializeField] private UIManager _uiManager;

    public void RestarVida(int daño)
    {
        _puntosVIda = _puntosVIda - daño;

    }

    public void SumarVida(int curar)
    {
        _puntosVIda = _puntosVIda + curar;

    }

    private void Update()
    {
        if (_puntosVIda >= 80)
        {
            _uiManager.ColorBarra(Color.green);
        }


        if (_puntosVIda < 40);
        {
           _uiManager.ColorBarra(new Color.red);

        }

        if (_puntosVIda <= 80f)
        {
            _uiManager.ColorBarra(new Color yellow);
        }

    }

    

}
