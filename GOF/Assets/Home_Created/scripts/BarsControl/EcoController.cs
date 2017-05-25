using UnityEngine;

public class EcoController : MonoBehaviour {

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
		value = value + time*barModifier.getEcoModifier ();
	}
}

