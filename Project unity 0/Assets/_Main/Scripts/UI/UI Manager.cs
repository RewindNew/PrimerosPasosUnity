using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private GameManager _GameManager;
    [SerializeField] private GameObject _panelOfvictory;

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

  
}