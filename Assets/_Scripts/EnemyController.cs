/*Source File name EnemyController
 * Author's Name yours truly Ibrahim Natchee (Abraham)
 * StudentID 300767752
 * Date Last Modified 10/22/2016
 * last modified by again Ibrahim Natchee
 * program descirption is simply the controllers by what the enemy is supposed to be acting on and where it respawns
 * Revision History every five minutes by an anxious student, 10/22/2016
*/


using UnityEngine;
using System.Collections;

[System.Serializable]
public class Speed {
	public float minSpeed, maxSpeed;
}

[System.Serializable]
public class Boundary {
	public float xMin, xMax, yMin, yMax;
}


public class EnemyController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public Speed speed;
	public Boundary boundary;
   private Transform _transform;
    public Transform SpawnPoint;
    // PRIVATE INSTANCE VARIABLES
    private float _CurrentSpeed;
	private float _CurrentDrift;

	// Use this for initialization
	void Start () {
		this._Reset ();
        this._transform=this.GetComponent<Transform>(); 
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = gameObject.GetComponent<Transform> ().position;
		currentPosition.y -= this._CurrentSpeed;
		gameObject.GetComponent<Transform> ().position = currentPosition;
		
		// Check bottom boundary
		if (currentPosition.y <= boundary.yMin) {
			this._Reset();
		}
	}

	// resets the gameObject
	private void _Reset() {
		this._CurrentSpeed = Random.Range (speed.minSpeed, speed.maxSpeed);
		Vector2 resetPosition = new Vector2 (Random.Range(boundary.xMin, boundary.xMax), boundary.yMax);
		gameObject.GetComponent<Transform> ().position = resetPosition;
        
}
    //when the tai fighter hits polayer it resets the tai fighter
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Destroy(other.gameObject);
            //Debug.Log("You hit a Tai Fighter");
            other.transform.position = this.SpawnPoint.position;
        }

    }

}
