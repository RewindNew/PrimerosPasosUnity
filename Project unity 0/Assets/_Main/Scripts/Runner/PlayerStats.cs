using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    public void RestarVida(int daño)
    {

     _puntosVida -= daño;

    }

    public void SumarVida(int heal)
    {

     _puntosVida += heal;
    
    }
}
