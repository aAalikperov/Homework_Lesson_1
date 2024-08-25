using UnityEngine;

public class ArrowsUI : MonoBehaviour {
    private void Update() {
        if ( Input.anyKeyDown == true ) {
            Destroy( gameObject );
        }
    }
}
