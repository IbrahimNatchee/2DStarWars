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
        this._resetenemy();
	}

    private void _resetenemy() {
}

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
