using Unity.VisualScripting;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGround;

    private void OnTriggerExit2D(Collider2D collition)
    {
        isGround = false;
        Debug.Log("estoy saltando!!");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        isGround = true;
        Debug.Log("Me tocaron");

    }

}
