using UnityEngine;

public class Playermovement : MonoBehaviour
{
    //variables

    public float altura = 1.77f;
    public int edad = 18;
    public string nombre = "Juan";
    public bool puedeVotar = true;


    public SpriteRenderer spriteRenderer;
    public GameObject gameObject;
    public Rigidbody2D rigidbody2D;
    public Collider2D collider2D;
    public Transform transform;

    private void Start()
    {
        Debug.Log(" Hola: " + nombre + " tu edad es: " + edad + " tu altura es: " + altura);
        rigidbody2D. simulated = false;

        spriteRenderer. color =  Color. red;

        transform. position = new Vector3(10,0,0);

    }

    private void Update()
    {
        
    }

}
