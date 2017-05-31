using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyObjectReaction : Reaction 
{
	public int objectPrize;
	public Toggle toggle;
	public shopConditionsManager shopConditionsManager;
	public Condition linkedCondition;

	private MoneyController moneyController;

	protected override void SpecificInit ()
	{
		moneyController = FindObjectOfType<MoneyController> ();
	}

	protected override void ImmediateReaction ()
	{

		if (toggle.isOn) 
		{
			if (moneyController.buyShopObject (objectPrize)) 
			{				
				shopConditionsManager.onPurchase (linkedCondition);
			} else 
			{
				toggle.isOn = false;
				//text message : not enough money
			}
		}

	}


}
