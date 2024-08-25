using UnityEngine;
using UnityEngine.Events;

public class HitManager : MonoBehaviour {
    public UnityEvent<Ball> OnHitBall;

    private void Update() {
        if ( Input.GetMouseButtonDown( 0 ) ) {
            Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
            Debug.DrawRay( Camera.main.ScreenToWorldPoint( Input.mousePosition ), Vector3.down, Color.yellow );
            if ( Physics.Raycast( ray, out RaycastHit hitInfo ) ) {
                if ( hitInfo.collider != null ) {
                    if ( hitInfo.collider.gameObject.TryGetComponent<Ball>( out Ball ball ) ) {
                        OnHitBall.Invoke( ball );
                    }
                }
            }
        }
    }
}
