using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyObjectReaction : Reaction 
{
	public int objectPrize;
	public Toggle toggle;

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
				//text message : object Purchased
			} else 
			{
				//text message : not enough money
			}
		}

	}


}
