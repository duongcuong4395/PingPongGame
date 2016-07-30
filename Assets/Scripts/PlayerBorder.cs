using UnityEngine;
using System.Collections;

public class PlayerBorder : MonoBehaviour {

	public ePlayer player;
	public ScoreUI score;

	void OnCollisionEnter(Collision col)
	{
        // Call another ball from another Ball(Script)
        // Get all variable and method, function,....
        Ball ball = col.gameObject.GetComponent<Ball> ();
		if (ball != null) {
			ball.transform.position = new Vector3 (0f, 1f, 0f);
            
            
            // 
            if (player == ePlayer.Right) {
				score.scorePlayerLeft++;
                ball.initialImpulse.x = 8.0f;
                ball.initialImpulse.z = 6.0f;
            } else if (player == ePlayer.Left) {
				score.scorePlayerRight++;
                ball.initialImpulse.x = 8.0f;
                ball.initialImpulse.z = 6.0f;

            }
		}
	}
}
