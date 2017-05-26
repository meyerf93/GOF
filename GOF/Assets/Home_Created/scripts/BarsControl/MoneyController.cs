using UnityEngine;

public class MoneyController : MonoBehaviour {

	public BarModifier barModifier;
	public int MAX;
	private float value;


	void Start()
	{
		value = (float)MAX;
	}
	public float getValue()
	{
		return value;
	}

	public void barUpdate (float time)
	{
		value = value + time*barModifier.getMoneyModifier ();
	}

	public bool buyShopObject(int prize)
	{
		if ((value - prize) < 0) 
		{
			return false;
		} else 
		{
			value -= prize;
			return true;
		}
	}
}
