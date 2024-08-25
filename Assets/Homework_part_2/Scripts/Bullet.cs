using UnityEngine;

public class Bullet : MonoBehaviour {
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;

    private void Start() {
        Invoke( "Destroy", _lifeTime );
    }
    private void FixedUpdate() {
        transform.Translate( transform.forward * _speed * Time.fixedDeltaTime );
    }
    private void Destroy() {
        Destroy( gameObject );
    }
    public void Init( Transform spawnTransform, float maxSpread = 0f ) {

        //разброс
        Quaternion spread = Quaternion.Euler( Random.Range( 0f, maxSpread ), Random.Range( 0f, maxSpread ), 1f );

        GameObject newBulletGameObject = Instantiate( gameObject, spawnTransform.position, spread, spawnTransform );
    }
}
