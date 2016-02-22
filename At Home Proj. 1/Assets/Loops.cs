using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour 
{
	int bowlsInTheCupboard = 7;


	void Start () 
	{
		while(bowlsInTheCupboard > 0)
		{
	Debug.Log ("I'm a stacked bowl, fear me!");
			bowlsInTheCupboard--;
   }
	}
}