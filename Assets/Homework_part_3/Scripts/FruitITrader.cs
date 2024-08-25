public class FruitITrader : ITrader
{
    private MerchantSpeech _merchantSpeech;

    public FruitITrader( MerchantSpeech merchantSpeech ) {
        _merchantSpeech = merchantSpeech;
    }

    public void Trade() {
        _merchantSpeech.SetText( "Fruit" );
    }
}
