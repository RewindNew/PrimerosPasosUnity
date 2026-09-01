using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;

    void Start()
    {
        _barra.color = Color.cyan;
        _barra.fillAmount = 100.0f;
    }

    void Update()
    {
        
    }
}
