using UnityEngine;
using System.Collections;

public class ScopesandAccess : MonoBehaviour
{
    public int alpha = 5;

    private int beta = 0;
    private int gamma = 5;

    private AnotherClass myOtherClass;

    void Start()
    {
        alpha = 29;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    void Example(int pencils, int paintbrushes)
    {
        int answer;
        answer = pencils * paintbrushes * alpha;
        Debug.Log(answer);
    }

    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}