using Unity.VisualScripting;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGround;
    private void OnTriggerEnter2D(Collider2D collition)
    {
        isGround = true;
        Debug.Log("Me tocaron");
    }
    private void OnTriggerExit2D(Collider2D collition)
    {
        isGround = false;
        Debug.Log("estoy saltando!!");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
       
    
    }

}
