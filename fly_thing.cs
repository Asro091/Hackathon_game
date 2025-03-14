using UnityEngine;

public class fly_thing : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float jumpstrength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true)
        {myRigidBody.linearVelocity=Vector2.up*jumpstrength;}
    }
}