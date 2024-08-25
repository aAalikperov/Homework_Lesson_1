public class ArmorITrader : ITrader
{
    private MerchantSpeech _merchantSpeech;

    public ArmorITrader( MerchantSpeech merchantSpeech ) {
        _merchantSpeech = merchantSpeech;
    }

    public void Trade() {
        _merchantSpeech.SetText( "Armor" );
    }
}
