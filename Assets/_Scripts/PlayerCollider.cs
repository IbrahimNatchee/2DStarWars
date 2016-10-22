/*Source File name PlayerCollider
 * Author's Name yours truly Ibrahim Natchee (Abraham)
 * StudentID 300767752
 * Date Last Modified 10/22/2016
 * last modified by again Ibrahim Natchee
 * Description is that this is a collider program to show the the player is going to hit a tai fighter and gonna make a debug.log in which it also trigger its respawn.
 * Revision History every five minutes by an anxious student, 10/22/2016
*/



using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {
    /*private Transform _transform;
    public Transform SpawnPoint;*/
    
	// Use this for initialization
	void Start () {
        /*this._transform = this.GetComponent<Transform>();
        Vector2 newPosition = this._transform.position;*/
        
    }
	
	// Update is called once per frame
	void Update () {
        
	}

   

    //its a trigger event in which i wannat him to yell that you hit a tai fighter

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //Destroy(other.gameObject);
            Debug.Log("You hit a Tai Fighter");
           // this._transform.position = this.SpawnPoint.position;
        }

    }
    
}
