using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;

public class CameraStuff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("In Start"); ;
        Dog dog = new Dog("Doggie");
        print(dog.Name);
        print("Hello.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("g"))
        {
            for (int i = 0; i < 3; i++)
            {
                print(Ask.Questions[i]);
            }
        }
        //print("In Update");
    }
}
