using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    [SerializeField] private Button _shotButton;
    [SerializeField] private GameObject _ammoUIField;

    private void Start() {
        HideShotButton();
        HideAmmoField();
        Player player = FindObjectOfType<Player>();
        if ( player != null ) {
            player.OnGunSetted.AddListener( ShowShotButton );
            player.OnGunSetted.AddListener( ShowAmmoField );
        }
    }
    private void ShowShotButton() {
        _shotButton.gameObject.SetActive( true );
    }
    private void HideShotButton() {
        _shotButton.gameObject.SetActive( false );
    }
    private void ShowAmmoField() {
        _ammoUIField.SetActive( true );
    }
    private void HideAmmoField() {
        _ammoUIField.SetActive( false );
    }
}
