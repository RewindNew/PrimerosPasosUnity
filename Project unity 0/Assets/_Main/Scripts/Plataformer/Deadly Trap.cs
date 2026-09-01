using UnityEngine;

public class DeadlyTrap : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _playerStats.RestarVida(); 
        }
    }

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
