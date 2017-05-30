using UnityEngine;
using UnityEngine.UI;

public class shopPersistency : MonoBehaviour {

	public Toggle toggle;
	public Condition condition;
	void Start () 
	{
		toggle.isOn = condition.satisfied;
	}
}
