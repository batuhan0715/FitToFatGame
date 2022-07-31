using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainW8Pizza : MonoBehaviour
{
    public CaloriCounter caloriCounter;
    public GameObject character;
    public bool isReleased;
    void Start()
    {
        isReleased = false;

    }


    void Update()
    {
        if (Input.GetMouseButtonUp(0) && isReleased)
        {
            Debug.Log("yemeks");
            character.transform.localScale += new Vector3(0.2f, 0.01f, 0);
            CaloriCounter.caloriValue += 300;
            Destroy(gameObject);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mouth")
        {

            isReleased = true;
        }
    }
}
