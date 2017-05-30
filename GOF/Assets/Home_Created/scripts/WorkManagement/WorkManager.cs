using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkManager : MonoBehaviour {

	public float targetTime;
	public ReactionCollection reactionCollection;

	private int workModifierID = 0;
	private bool activated = false;
	private BarModifier barModifier;

	void Start()
	{
		barModifier = FindObjectOfType<BarModifier> ();
	}
	public void workStart () 
	{
		if (targetTime > 0) 
		{
			activated = true;
			workModifierID = barModifier.addToModifiers(new Modifier("WorkToDo",10,0,0));
		}
	}

	public bool isOn()
	{
		return activated;
	}

	public void workEnd()
	{
		activated = false;
		barModifier.removeFromModifiers(workModifierID);
		workModifierID = 0;
	}
	// Update is called once per frame
	void Update () 
	{
		if (activated) 
		{
			if (targetTime >= 0) 
			{
				targetTime -= Time.deltaTime;
				if (targetTime < 0) 
				{
					workEnd ();
					workFinished ();

				}
			} 
			else 
			{
				activated = false;
			}
		}			
	}
	public void workFinished()
	{
		reactionCollection.React();
	}
}
