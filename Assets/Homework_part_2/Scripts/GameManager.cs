using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] private Player _player;

    public void SetPlayerWeapon( GameObject gunPrefab ) {
        _player.SetGun( gunPrefab );
    }
    public void SetPlayerShooterPatternOneShot() {
        _player.GetGun()?.SetShooter( new OneShot_Pattern() );
    }
    public void SetPlayerShooterPatternTripleShot() {
        _player.GetGun()?.SetShooter( new TripleShot_Pattern() );
    }
}
