using UnityEngine;

public class Healing : MonoBehaviour
{
    [SerializeField] private int _puntosVIda = 100;
    [SerializeField] private PlayerStats _playerStats;

    private void OnTriggerEnter2D(Collider2D collision)
    {
          
        if (collision.gameObject.tag == "Player")
        {
            _playerStats.SumarVida(10);
            Destroy(this.gameObject);    
        }
    }




}


