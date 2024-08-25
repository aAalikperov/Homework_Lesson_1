using UnityEngine;
using UnityEngine.UI;

public class UIAmmoVal : MonoBehaviour {
    [SerializeField] private Text _ammoVal;
    private Player _player;

    private void Start() {
        _player = FindObjectOfType<Player>();
        if ( _player != null ) {
            _player.OnShotted.AddListener( SetAmmoVal );
            _player.OnGunSetted.AddListener( SetAmmoVal );
        }
    }

    private void SetAmmoVal() {
        if ( _player == null )
            return;

        if ( _player.GetGun()?.GetIsInfinityAmmo() == true )
            _ammoVal.text = "Inf";
        else
            _ammoVal.text = _player.GetGun()?.GetAmmo().ToString();
    }
}
