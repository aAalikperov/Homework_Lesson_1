using System;

public interface IGameOverChecker {
    bool IsGameOver( Type typeOfBall );
    bool IsLose();
    bool IsWin();
}
