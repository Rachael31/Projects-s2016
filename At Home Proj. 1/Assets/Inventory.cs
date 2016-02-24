using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int fire;
        public int lasers;
        public float fuel;

        public Stuff(int bul, int fi, int las)
        {
            bullets = bul;
            fire = fi;
            lasers = las;
        }

        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }

        // Constructor
        public Stuff()
        {
            bullets = 1;
            lasers = 1;
            fire = 1;
        }
    }


    // Creating an Instance (an Object) of the Stuff class
    public Stuff myStuff = new Stuff(50, 5, 5);

    public Stuff myOtherStuff = new Stuff(50, 1.5f);

    void Start()
    {
        Debug.Log(myStuff.bullets);
    }
}
