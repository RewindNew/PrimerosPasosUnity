using UnityEngine;

public class DeadlyTrap : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerStats.RestarVida(10); 
            _uiManager.RestarFillAmount(0.2f);
        }
    }

     
    void Update()
    {
        
    }
}
