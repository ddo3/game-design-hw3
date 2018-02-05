using UnityEngine;
using System.Collections;

public class ReactiveTarget : MonoBehaviour {

	public void ReactToHit() {
		WanderingAI behavior = GetComponent<WanderingAI>();
		if (behavior != null) {
			behavior.SetAlive(false);
		}
		StartCoroutine(Die());
	}


	// is this where the player or the enemy dies ????
	private IEnumerator Die() {
		this.transform.Rotate(-75, 0, 0);
		//this.transform.Rotate(-128, 0, 0);
		yield return new WaitForSeconds(1.5f);
		
		Destroy(this.gameObject);
	}
}
