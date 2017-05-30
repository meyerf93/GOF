using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : MonoBehaviour {

	public float targetTime;
	public ReactionCollection timeUp;
	public ReactionCollection timeLeft30;
	public ReactionCollection timeLeft20;
	public ReactionCollection timeLeft10;
	
	void Update () 
	{
		targetTime -= Time.deltaTime;
		if ((int)targetTime == 30) {
			
		} else if ((int)targetTime == 20) {
		} else if ((int)targetTime == 10) {
		}
		if (targetTime <= 0.0f)
		{
			timerEnded();
		}

	}
	private void timerEnded()
	{
		timeUp.React();
	}
	private void TimeLeft30()
	{
		timeLeft30.React ();
	}
	private void TimeLeft20()
	{
		timeLeft20.React ();
	}
	private void TimeLeft10()
	{
		timeLeft10.React ();
	}
}
