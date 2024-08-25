using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    [SerializeField] private float _speed = 1f;

    private void Update() {
        Vector3 moving = Vector3.zero;
        if ( Input.GetKey( KeyCode.UpArrow ) ) {
            moving += Vector3.forward;
        }
        if ( Input.GetKey( KeyCode.DownArrow ) ) {
            moving += Vector3.back;
        }
        if ( Input.GetKey( KeyCode.LeftArrow ) ) {
            moving += Vector3.left;
        }
        if ( Input.GetKey( KeyCode.RightArrow ) ) {
            moving += Vector3.right;
        }

        transform.Translate( moving * _speed * Time.deltaTime );
    }
}
