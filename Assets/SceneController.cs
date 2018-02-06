using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {
	[SerializeField] private GameObject enemyPrefab;
	private GameObject _enemy;
    private ArrayList _enemies;

	void Update() {

        //if (_enemies == null)
        //{
        //    _enemies = new ArrayList();

        //    GameObject newEnemy = new GameObject();

        //    newEnemy = Instantiate(enemyPrefab) as GameObject;

        //    newEnemy.transform.position = new Vector3(0, 1, 0);

        //    float angle = Random.Range(0, 360);

        //    newEnemy.transform.Rotate(0, angle, 0);

        //    _enemies.Add(newEnemy);

        //}

        //if (_enemies.Contains(null))
        //{
        //    int deadEnemyIndex = _enemies.IndexOf(null);

        //    //recreate dead enemy
        //    GameObject deadEnemy = (GameObject)_enemies[deadEnemyIndex];

        //    deadEnemy = Instantiate(enemyPrefab) as GameObject;

        //    deadEnemy.transform.position = new Vector3(0, 1, 0);

        //    float angle = Random.Range(0, 360);

        //    deadEnemy.transform.Rotate(0, angle, 0);

        //    _enemies.Insert(deadEnemyIndex, deadEnemy);

        //    //add new enemy to the list
        //    //GameObject newEnemy = new GameObject();

        //   /// newEnemy = Instantiate(enemyPrefab) as GameObject;

        //    //newEnemy.transform.position = new Vector3(0, 1, 0);

        //    ///angle = Random.Range(0, 360);

        //    //newEnemy.transform.Rotate(0, angle, 0);

        //    //_enemies.Add(newEnemy);
        //}

        if (_enemy == null)
        {

            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);

            _enemy.transform.Rotate(0, angle, 0);


            GameObject newE = new GameObject();
            newE = Instantiate(enemyPrefab) as GameObject;
            newE.transform.position = new Vector3(0, 1, 0);
            angle = Random.Range(0, 360);

            newE.transform.Rotate(0, angle, 0);
        }
    }
}
