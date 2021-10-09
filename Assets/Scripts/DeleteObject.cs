using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteObject : MonoBehaviour
{
    public float coinZ = 1;
    public static int counter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 0.0f, coinZ);
    }

    void OnTriggerEnter(){
        if (counter == 9)
        {
         SceneManager.LoadScene("End");
        }
        counter = counter + 1;
        Destroy(gameObject);
    }   
}
