using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRatingUI : MonoBehaviour {
    [SerializeField] private Text _text;
    [SerializeField] private string _textTemplate = "Rating ";

    private void Start() {
        FindObjectOfType<PlayerHW3>().OnSetRating.AddListener( SetRatingText );
    }

    private void SetRatingText( int ratingValue ) {
        _text.text = _textTemplate + ratingValue.ToString();
    }
}
