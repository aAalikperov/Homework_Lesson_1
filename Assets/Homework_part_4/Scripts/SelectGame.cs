using UnityEngine;

public class SelectGame : MonoBehaviour {
    private GameManagerHW4 _gameManagerHW4;

    private void Start() {
        _gameManagerHW4 = FindObjectOfType<GameManagerHW4>();
    }

    public void SetAllBallsGame() {
        int allBallsCount = FindObjectsOfType<Ball>().Length;
        _gameManagerHW4.SetGameOverChecker( new AllBallsChecker( allBallsCount ) );
    }
    public void SetOneColorBallsGame() {
        _gameManagerHW4.SetGameOverChecker( new OneColorBallsChecker() );
    }
}
