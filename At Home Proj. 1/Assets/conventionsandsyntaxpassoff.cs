using UnityEngine;
using System.Collections;

public class BasicSyntax : MonoBehaviour;
{
    void Start()
    {
        // This line will tell me position x of my object.
        /* Hey, this is my multiple line comment!
         * End of line.
         */ 
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to splatter!");
        }
    }
}
