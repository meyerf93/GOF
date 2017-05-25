using UnityEngine;
using UnityEngine.UI;

public class shopTest : MonoBehaviour {

	public BarModifier barModifier;
	public MoneyController moneyController;
	public EcoController ecoController;
	public ConfortController confortController;
	private LevelTimer levelTimer;
	public Text text;

	// Use this for initialization
	void Start () 
	{
		levelTimer = FindObjectOfType<LevelTimer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (levelTimer == null) {
			levelTimer = FindObjectOfType<LevelTimer> ();
			text.text = "money :  " + (int)moneyController.getValue () +", modifier : " + barModifier.getMoneyModifier() + "\n" + 
				"eco :  " + (int)ecoController.getValue()  + ", modifier : " + barModifier.getEcoModifier() + "\n" 
				+ "comfort :  " + (int)confortController.getValue()  + ", modifier : " + barModifier.getComfortModifier() +  "\n" ;
		} else 
		{
			float timeElapsed = Time.deltaTime;
			moneyController.barUpdate (timeElapsed);
			ecoController.barUpdate (timeElapsed);
			confortController.barUpdate (timeElapsed);

			text.text = "money :  " + (int)moneyController.getValue () +", modifier : " + barModifier.getMoneyModifier() + "\n" + 
				"eco :  " + (int)ecoController.getValue()  + ", modifier : " + barModifier.getEcoModifier() + "\n" 
				+ "comfort :  " + (int)confortController.getValue()  + ", modifier : " + barModifier.getComfortModifier() +  "\n" 
				+ "time Left : " + (int)levelTimer.targetTime;
			
		}

	}
}
