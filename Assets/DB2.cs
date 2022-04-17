using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DB2 : MonoBehaviour
{




    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.P)) {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.M)) {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.L)) {
            SceneManager.LoadScene(2);
        }

        if (Input.GetKeyDown(KeyCode.O)) {
            SceneManager.LoadScene(3);
        }

    }   };
