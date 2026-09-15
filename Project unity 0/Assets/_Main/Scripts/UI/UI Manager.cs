using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;
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