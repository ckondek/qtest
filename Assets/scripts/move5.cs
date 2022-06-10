using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move5 : MonoBehaviour
{
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        transform.position = new Vector3(2, 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        counter += 1;
        if (counter < 300)
        {
            transform.position += new Vector3((float)(0.5 *  Time.deltaTime), 0, 0);
        }
        else if (counter < 600)
        {
            transform.position += new Vector3((float)(-0.5 *  Time.deltaTime), 0, 0);
        }
        else {
            counter = 0;
        }
       
    }
}
