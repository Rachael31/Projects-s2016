using UnityEngine;
using System.Collections;

public class IfThen : MonoBehaviour
{
    public float waterTemperature = 75.0f;
    public float hotLimitTemperature = 55.0f;
   public float coldLimitTemperature = 30.0f;


    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        waterTemperature -= Time.deltaTime * 5f;
    }
    

    void TemperatureTest ()
    {  
        // If the water's temperature is greater than the hottest drinking temperature...
        if (waterTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("This water is too hot!");
        }
        // If it isn't, but the water temperature is less than the coldest drinking temperature...
        else if (waterTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("This water is freezing cold!");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("The water is just right.");
        }
    }
}

    