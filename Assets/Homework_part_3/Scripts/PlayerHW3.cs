using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHW3 : MonoBehaviour {
    [SerializeField] private int _rating = 0;
    [Space]
    [Header( "Events" )]
    public UnityEvent<int> OnSetRating;

    public int GetRating() {
        return _rating;
    }
    public void SetRating( int newRating ) {
        if ( _rating == newRating || newRating < 0 || newRating > 2 )
            return;

        _rating = newRating;
        OnSetRating.Invoke( _rating );
    }
    public void UpRating() {
        SetRating( _rating + 1 );
    }
    public void DownRating() {
        SetRating( _rating - 1 );
    }
}
