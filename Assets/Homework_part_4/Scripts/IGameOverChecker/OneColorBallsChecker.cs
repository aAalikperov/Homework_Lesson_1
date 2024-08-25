using System;
using UnityEngine;

public class OneColorBallsChecker : MonoBehaviour, IGameOverChecker {

    private Type _thisBallNeedToHit = null;
    private int _thisBallNeedToHitNum = 0;
    private int _ballHitCounter = 0;

    public bool IsGameOver( Type ballType ) {
        if ( _thisBallNeedToHit == null ) {
            SetNeedToHitBall( ballType );
        }
        if ( _thisBallNeedToHit == ballType ) {
            _ballHitCounter++;
            if ( _ballHitCounter >= _thisBallNeedToHitNum ) {
                return true;
            } else {
                return false;
            }
        } else {
            return true;
        }
    }

    public bool IsLose() {
        if ( _ballHitCounter < _thisBallNeedToHitNum ) {
            return true;
        } else {
            return false;
        }
    }

    public bool IsWin() {
        if ( _ballHitCounter == _thisBallNeedToHitNum ) {
            return true;
        } else {
            return false;
        }
    }

    private void SetNeedToHitBall( Type ballType ) {
        _thisBallNeedToHit = ballType;
        _thisBallNeedToHitNum = FindObjectsOfType( ballType ).Length;
    }
}
