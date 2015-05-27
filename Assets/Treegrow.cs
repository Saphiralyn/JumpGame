using UnityEngine;
public class Treegrow : MonoBehaviour
{
	public GameObject treeleft;
	public GameObject treeright;

	public float spawnTime = 1.0f;
	public Transform[] spawnPoints;
	int i=0;

	void Start(){
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Spawn ()
	{
		
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		if (i % 2 == 0) {
			Instantiate (treeleft, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
		}
			else 
			Instantiate (treeright, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		i++;
	}
}
