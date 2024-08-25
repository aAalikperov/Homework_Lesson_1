using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Carpet : MonoBehaviour {
    public UnityEvent<Collider> OnCarpetEnter;
    public UnityEvent<Collider> OnCarpetExit;

    private void OnTriggerEnter( Collider other ) {
        OnCarpetEnter.Invoke( other );
    }
    private void OnTriggerExit( Collider other ) {
        OnCarpetExit.Invoke( other );
    }
}
