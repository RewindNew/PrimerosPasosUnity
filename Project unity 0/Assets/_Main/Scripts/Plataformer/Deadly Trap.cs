using UnityEngine;

public class DeadlyTrap : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerStats.RestarVida(10); 
        }
    }

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
