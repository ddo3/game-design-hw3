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


	//This is where the enemy dies
	private IEnumerator Die() {
        float angle = 0;
        bool angleIs90 = false;
        while (!angleIs90)
        {
            angle += 10;

            this.transform.Rotate(10, 0, 0);

            yield return new WaitForSeconds(0.027f);

            angleIs90 = (angle == 90);
        }

        //this.transform.Rotate(-75, 0, 0);
        //this.transform.Rotate(-128, 0, 0);
        yield return new WaitForSeconds(1.5f);
		
		Destroy(this.gameObject);
	}
}
