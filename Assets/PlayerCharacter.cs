using UnityEngine;
using System.Collections;

public class PlayerCharacter : MonoBehaviour {
	private int _health;

	void OnGUI(){
		GUI.Label (new Rect (10, 10, 100, 20), HealthBar());
	}

	void Start() {
		_health = 5;
		OnGUI ();
	}

	public void Hurt(int damage) {
		_health -= damage;
		Debug.Log("Health: " + _health);
		OnGUI ();
	}

	private string HealthBar(){
		
		string healthBar = "";
		for(int i = 0; i <= _health ; i++){
			healthBar = healthBar + "*";
		}

		return healthBar;
	}
}
