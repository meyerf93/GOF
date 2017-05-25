using UnityEngine;

public class ConfortController : MonoBehaviour {

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
		value = value + time*barModifier.getComfortModifier ();
	}
}


