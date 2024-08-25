using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameOver : MonoBehaviour {
    [SerializeField] private GameObject _loseUI;
    [SerializeField] private GameObject _winUI;
    [SerializeField] private GameObject _bg;
    [SerializeField] private GameObject _restart;

    private void Start() {
        _loseUI.SetActive( false );
        _winUI.SetActive( false );
        _bg.SetActive( false );
        _restart.SetActive( false );
    }

    public void ShowLoseUI() {
        _loseUI.SetActive( true );
        _winUI.SetActive( false );
        _bg.SetActive( true );
        _restart.SetActive( true );
    }
    public void ShowWinUI() {
        _winUI.SetActive( true );
        _loseUI.SetActive( false );
        _bg.SetActive( true );
        _restart.SetActive( true );
    }

    public void RestartScene() {
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
    }
}
