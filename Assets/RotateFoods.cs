using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotateFoods : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(2, 0, 0));
        if (Input.GetKeyDown("f"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
