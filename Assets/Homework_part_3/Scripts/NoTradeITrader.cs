public class NoTradeITrader: ITrader {

    private MerchantSpeech _merchantSpeech;

    public NoTradeITrader( MerchantSpeech merchantSpeech ) {
        _merchantSpeech = merchantSpeech;
    }

    public void Trade() {
        _merchantSpeech.SetText( "Nope" );
    }
}
