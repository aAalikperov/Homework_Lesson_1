using System;

public class AllBallsChecker : IGameOverChecker {

    private int _allBallNum = 0;
    private int _hitBallsCounter = 0;

    public AllBallsChecker( int allBallNum ) {
        _allBallNum = allBallNum;
    }

    public bool IsGameOver( Type ballType ) {
        _hitBallsCounter++;
        if ( _hitBallsCounter >= _allBallNum )
            return true;
        else
            return false;
    }
    public bool IsLose() {
        if ( _hitBallsCounter < _allBallNum )
            return true;
        else
            return false;
    }
    public bool IsWin() {
        if ( _hitBallsCounter == _allBallNum )
            return true;
        else
            return false;
    }
}
