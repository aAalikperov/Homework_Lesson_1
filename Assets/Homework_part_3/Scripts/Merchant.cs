using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : MonoBehaviour {

    private ITrader _trader;
    [SerializeField] private MerchantSpeech _merchantSpeech;

    public void SetTrader( ITrader trader ) {
        _trader = trader;
    }
    public void Trade() {
        _trader.Trade();
    }
    public MerchantSpeech GetMerchantSpeech() {
        return _merchantSpeech;
    }

}
