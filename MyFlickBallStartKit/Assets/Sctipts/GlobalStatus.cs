public class GlobalStatus {

	public enum GameStatus
	{
		BallStatus_WaitShoot = 0,
		BallStatus_Rolling
	}

	public static GameStatus CurrentGameStatus = GameStatus.BallStatus_WaitShoot;

}
