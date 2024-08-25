using UnityEngine;

public class TradeManager : MonoBehaviour {
    [SerializeField] private Merchant _merchant;
    [SerializeField] private PlayerHW3 _playerHW3;

    public void SetMerchantTrader() {
        if ( _playerHW3.GetRating() == 0 ) {
            _merchant.SetTrader( new NoTradeITrader( _merchant.GetMerchantSpeech() ) );
        } else if ( _playerHW3.GetRating() == 1 ) {
            _merchant.SetTrader( new FruitITrader( _merchant.GetMerchantSpeech() ) );
        } else if ( _playerHW3.GetRating() == 2 ) {
            _merchant.SetTrader( new ArmorITrader( _merchant.GetMerchantSpeech() ) );
        }
    }

}
