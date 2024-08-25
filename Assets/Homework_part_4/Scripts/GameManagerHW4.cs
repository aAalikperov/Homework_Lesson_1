using System;
using UnityEngine;

public class GameManagerHW4 : MonoBehaviour {
    [SerializeField] private HitManager _hitManager;
    [SerializeField] private UIGameOver _uIGameOver;
    private IGameOverChecker _gameOverChecker;
    private bool _IsGamePlay = false;

    private void Start() {
        _hitManager.OnHitBall.AddListener( BallHit );
    }

    public void SetGameOverChecker( IGameOverChecker gameOverChecker ) {
        _gameOverChecker = gameOverChecker;
    }
    public void SetGamePlayBool( bool gamePlayBool ) {
        _IsGamePlay = gamePlayBool;
    }

    private void BallHit( Ball ball ) {
        if ( _IsGamePlay == false )
            return;

        Type ballType = ball.GetType();
        Destroy( ball.gameObject );

        if ( _gameOverChecker.IsGameOver( ballType ) == true ) {
            SetGamePlayBool( false );
            if ( _gameOverChecker.IsWin() == true ) {
                _uIGameOver.ShowWinUI();
            } else {
                _uIGameOver.ShowLoseUI();
            }
        }
    }
}
