using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Welkom to NumberWIzard");
		print ("Pick a number, but don't tell me!!");
		int numMax = 1000;
		int numMin = 1;
		
		print ("The highest number you can pick is "  + numMax + ", while the lowest number you can pick is "  + numMin);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
