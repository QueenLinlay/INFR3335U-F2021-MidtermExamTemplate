using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
	public float speed = 10.0f;
    public int counter = 0;
	Rigidbody rigidbody;

	// Start is called before the first frame update
	void Start()
    {
		rigidbody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame



	void FixedUpdate()
	{
        float veloX = Input.GetAxis("Horizontal");
        float veloZ = Input.GetAxis("Vertical");

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

        rigidbody.AddForce(veloInput * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        counter = counter + 1;
        if (counter == 10)
        {
            SceneManager.LoadScene("End");
        }
    }
}
