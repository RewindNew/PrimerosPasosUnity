using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    [SerializeField] private Image _barra;
    [SerializeField] private int _vidaMaxima = 100;
    public void RestarVida(int daño)
    {

     _puntosVida -= daño;

    }

    public void SumarVida(int heal)
    {

     _puntosVida += heal;
    
        if(_puntosVida > _vidaMaxima)
        {
            _puntosVida = _vidaMaxima;
        }
    }

    

    private void Update()
    {
        if (_barra.fillAmount >= 0.8f)
        {
            _barra.color = Color.green;
        }
        
        if(_barra.fillAmount <= 0.7f)
        {
            _barra.color = Color.yellow;
        }

        if(_barra.fillAmount <= 0.3f)
        {
            _barra.color = Color.red;
        }


    }

}
