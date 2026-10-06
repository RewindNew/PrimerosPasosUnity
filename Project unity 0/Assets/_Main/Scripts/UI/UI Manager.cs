using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;

    [SerializeField] private GameManager _gameManager;
    private GameManager puntosvida;
    [SerializeField] private GameObject _panelOfDeath;

    public void SumarFillAmount(float amount)
    {
        _barra.fillAmount = _barra.fillAmount + amount;
        Debug.Log("SumarBarra");
    }
    public void RestarFillAmount(float amount )
    {
        _barra.fillAmount = _barra.fillAmount - amount;
        Debug.Log("RestarBarra");
    }

    public void ColorBarra(Color mycolor)
    {
        _barra.color = mycolor;
    }

    public void Update()
    {
        if (_gameManager._puntosVidaActuales <= 0)
        {
            _panelOfDeath.SetActive(true);
        }
    }
}