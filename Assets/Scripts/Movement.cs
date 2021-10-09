using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 RotateObject;
    public float speed = 10.0f;
    //public float RSpeed = 10.0f;
    public float MouseXSpeed = 10.0f;

	// Start is called before the first frame update
	void Start()
    {
		rigidbody = GetComponent<Rigidbody>();
        RotateObject = new Vector3(0, 0, 0);
	}

	// Update is called once per frame

    //I have tried to add a fix view of the character, like if camera rotate than object will do so. However got stuck trying to keep object and camera rotating same time
    //So I tried my best.

	void FixedUpdate()
	{
        float veloX = Input.GetAxis("Horizontal");
        float veloZ = Input.GetAxis("Vertical");
        float MouseX = MouseXSpeed * Input.GetAxis("Mouse X");

        Vector3 veloInput = new Vector3(veloX, 0, veloZ);
        veloInput = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y, 0) * veloInput;

        Debug.Log(veloInput);

        Debug.Log(rigidbody.transform.position);
        //Debug.Log(veloX);
        //Debug.Log(veloZ);
       
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.D)))
        {
            rigidbody.AddForce(veloInput * speed);
            
        }
       // transform.LookAt(Camera.main.transform.right);
      //transform.Rotate(Camera.main.transform.up, -MouseX);
        //transform.Rotate(Camera.main.transform.right, MouseY);
        transform.Rotate(0.0f, -MouseX, 0);
        rigidbody.AddForce(veloInput * speed);
        rigidbody.useGravity = true;
        rigidbody.isKinematic = false;

    }
}
