using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

    public float thrust;
    public Vector3 eulerAngleVelocity;
    public Rigidbody rb;
    public bool w,s,a,d;
    // Use this for initialization
    void Start () {
        thrust = 5.0f;
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, thrust));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, -thrust));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-thrust, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(thrust, 0, 0));
        }
    }
}
