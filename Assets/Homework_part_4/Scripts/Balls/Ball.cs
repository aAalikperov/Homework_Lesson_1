using UnityEngine;

public abstract class Ball : MonoBehaviour {
    public void Destroy() {
        Destroy( gameObject );
    }
}
