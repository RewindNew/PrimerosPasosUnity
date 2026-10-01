using UnityEngine;

public class Victoryorder : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private GameManager _GameManager;
    [SerializeField] private GameObject _panelOfvictory;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _GameManager.PausarElJuego();
            _panelOfvictory.SetActive(true);
        }
    }

}
