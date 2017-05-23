using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : MonoBehaviour {

	public float targetTime;
	public ReactionCollection targetReactionCollection;
	
	void Update () 
	{
		targetTime -= Time.deltaTime;

		if (targetTime <= 0.0f)
		{
			timerEnded();
		}

	}
	void timerEnded()
	{
		targetReactionCollection.React();
	}
}
