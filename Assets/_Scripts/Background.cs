/*Source File name Background
 * Author's Name yours truly Ibrahim Natchee (Abraham)
 * StudentID 300767752
 * Date Last Modified 10/22/2016
 * last modified by again Ibrahim Natchee
 * Description is this is the background that adds a scrolling space theme to it, we're WARPIN!
 * Revision History every five minutes by an anxious student, 10/22/2016
*/

using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {


    //Private onstance variables

    private int _speed;
    private Transform _transform;
    public int Speed
    {

        get
        {
            return this._speed;
        }
        set
        {

            this._speed = value;
        }
    }

    // Use this for initialization
    void Start()
    {
        //telling compiler that the transform component that directly comes from my object (space asset) 
        //I'm getting a reference to it and storing it into this private local variable _transform
        //so now my current position is being stored in the _transform component, keeps track of where I am
        //Transform keeps track of location, rotation and scale
        this._transform = this.GetComponent<Transform>();
        this._reset();
    }

    // Update is called once per frame
    void Update()
    {

        //initiate the move method and the boundary method
        this._move();
        this._checkBounds();
    }

    //this method move game object space down by screen by _speed px every frame
    private void _move()
    {
        //now we created a Vector (cause it has an X and a Y 2d coordinates) new variable called newPosition and assigned it the value
        //of _transform so we can move from old orginal position (_transform) to new position(newPosition) with speed 5
        Vector2 newPosition = this._transform.position;

        //can't change the _transform variable since that would break the rules since it is equal to Transform directly but we can
        //modify newPosition as much as we want.
        //here we are saying take old coordination position from _transform and give it to newPosition then add _speed to it.
        newPosition.y -= this._speed;

        //assigning back the new position thats had speed added to it
        this._transform.position = newPosition;
    }

    //this method checks to see the game objects meets the top-border of the screen
    private void _checkBounds()
    {
        if (this._transform.position.y <= -10.17f)
        {
            //if it reaches that point then activate the _reset method
            this._reset();
        }
    }

    //this method reset the game object space to original position
    private void _reset()
    {
        this._speed = 5;
        //in here we just simply assign a new Vector value to keep it specific and simple
        this._transform.position = new Vector2(0f, 10.06f);
    }
}
