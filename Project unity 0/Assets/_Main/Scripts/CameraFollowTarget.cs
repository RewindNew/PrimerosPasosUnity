using Unity.VisualScripting;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    [SerializeField] private Transform _target;


    void Start()
    {
        
    }


    void Update()
    {
        this.transform.position = new Vector3(_target.position.x, this.transform.position.y, this.transform.position.z);
    }
}
