using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    [SerializeField] private Transform _objetivo;


    private void Update()
    {

     this.transform.position = new Vector3(_objetivo.position.x, transform.position.y, transform.position.z);

    }

}