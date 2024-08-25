using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour {
    [SerializeField] private Gun _currentGun;
    [SerializeField] private Transform _gunHandTransform;
    [Space]
    [Header( "Events" )]
    public UnityEvent OnGunSetted;
    public UnityEvent OnShotted;

    public void SetGun( GameObject gunPrefab ) {
        if ( gunPrefab.TryGetComponent( out Gun gun ) ) {
            if ( _currentGun == gun )
                return;

            if ( _currentGun != null )
                _currentGun.Hide();

            GameObject newGunGameObject = Instantiate( gunPrefab, _gunHandTransform );
            _currentGun = newGunGameObject.GetComponent<Gun>();

            OnGunSetted.Invoke();
        }
    }
    public void Shot() {
        if ( _currentGun == null )
            return;

        _currentGun.Shot();

        OnShotted.Invoke();
    }

    public Gun GetGun() {
        return _currentGun;
    }
}
