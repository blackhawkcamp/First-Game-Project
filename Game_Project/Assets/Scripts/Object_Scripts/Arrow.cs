using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D myRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Setup(Vector2 velocity, Vector3 direction)
    {
        myRigidbody.velocity = velocity.normalized * speed;
        transform.rotation = Quaternion.Euler(direction);

    }




}
