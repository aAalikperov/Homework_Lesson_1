using UnityEngine;

public class Gun : MonoBehaviour {

    [SerializeField] private IShooter _shooter;
    [SerializeField] private int _ammo;
    [SerializeField] private bool _isInfinityAmmo = false;
    [SerializeField] private Transform _bulletSpawner;
    [SerializeField] private GameObject _bulletPrefab;

    public void Shot() {
        if ( _shooter == null )
            return;

        if ( _isInfinityAmmo == false ) {
            _ammo -= _shooter.Shot( _ammo, _bulletSpawner, _bulletPrefab );
        } else {
            _shooter.Shot( int.MaxValue, _bulletSpawner, _bulletPrefab );
        }
    }
    public void Hide() {
        Destroy( gameObject );
    }

    public void SetShooter( IShooter shooter ) {
        _shooter = shooter;
    }
    public int GetAmmo() {
        return _ammo;
    }
    public bool GetIsInfinityAmmo() {
        return _isInfinityAmmo;
    }
}
