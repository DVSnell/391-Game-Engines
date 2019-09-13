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
        int n = 0;

        print(Ask.Questions[n]);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("g"))
        {

                for (int n = 0; n < 1;)
                {
                    print(Ask.Answers[Ask.i]);
                    n++;
                    Ask.i++;
                if (Ask.i < 4)
                {
                    print(Ask.Questions[Ask.i]);
                }
            }

        }

        //print("In Update");

    }
}
