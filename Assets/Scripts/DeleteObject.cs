using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteObject : MonoBehaviour
{
    public static int counter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(){
        if (counter == 9)
        {
         SceneManager.LoadScene("End");
        }
        counter = counter + 1;
        Destroy(gameObject);
    }   
}
