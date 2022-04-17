using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(0);
            Debug.Log("works");
        }

        if(Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene(1);
            Debug.Log("works");
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene(2);
            Debug.Log("works");
        }

    }
}
