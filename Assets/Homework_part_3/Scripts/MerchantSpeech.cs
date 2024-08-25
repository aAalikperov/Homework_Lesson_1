using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MerchantSpeech : MonoBehaviour {
    [SerializeField] private Text _text;

    public void SetText( string text ) {
        Show();
        _text.text = text;
    }

    public void Hide() {
        _text.enabled = false;
    }
    public void Show() {
        _text.enabled = true;
    }
}
