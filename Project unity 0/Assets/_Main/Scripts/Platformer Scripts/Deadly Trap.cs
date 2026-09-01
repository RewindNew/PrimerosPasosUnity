using UnityEngine;

public class DeadlyTrap : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"));
        {
            Destroy(collision.gameObject);
        }
    }

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
