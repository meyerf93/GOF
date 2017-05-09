using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used for the Health Bar

public class PlayerHealth : MonoBehaviour {

    public float max_Health = 100f;
    public float cur_Health = 0f;
    public GameObject healthBar;

	// Use this for initialization
	void Start () {
        cur_Health = max_Health;
        InvokeRepeating("decreasehealth", 1f, 1f);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void decreasehealth() {
        if (cur_Health > 0f) {
            cur_Health -= 2f;
            float calc_Health = cur_Health / max_Health; // if cur_Health 80 / 100 = 0.8f
            setHealthBar(calc_Health);
        }
    }

    public void setHealthBar(float myHealth) {
        //myHealth value 6-1

        healthBar.transform.localScale = new Vector3(healthBar.transform.localScale.x, myHealth, healthBar.transform.localScale.z);
    }
}
