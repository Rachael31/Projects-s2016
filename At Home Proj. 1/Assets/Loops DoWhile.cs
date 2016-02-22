using UnityEngine;
using System.Collections;

public class LoopsDoWhile : MonoBehaviour

{
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello World");

        } while (shouldContinue == true);
    }
}