using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVIda = 100;

    public void RestarVida(int daño)
    {
        _puntosVIda = _puntosVIda - daño;

        
    }
}
