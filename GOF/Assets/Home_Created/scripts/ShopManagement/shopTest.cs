using UnityEngine;
using UnityEngine.UI;

public class shopTest : MonoBehaviour {

	public BarModifier barModifier;
	public Text text;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		text.text = "money :  " + barModifier.getMoneyModifier() + "\n" + "eco :  " + barModifier.getEcoModifier() + "\n" 
			+ "comfort :  " + barModifier.getComfortModifier() + "\n" + "number of elements : " + barModifier.getCount();
		
	}
}
