using UnityEngine;
using System.Collections;

public class Pattern : MonoBehaviour {
    private int[] pattern = new int[8]; //Store pattern
    private double timeStep = 0; //Time each step waits

	// Use this for initialization
	void Start () {
        genPattern(5);
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void genPattern(int seed)
    {
        int[] keys = new int[Random.Range(1, seed + 1) + 1]; //One for each key, plus the zero
        keys[0] = 0;

        for (int loop = 1; loop <= keys.Length; ++loop)
        {
            keys[loop] = Random.Range(1, 9);
            //Debug.Log(keys[loop]);
        }

        for (int loop = 0; loop < pattern.Length; ++loop)
        {
            pattern[loop] = keys[Random.Range(0, keys.Length - 1];
            Debug.Log(pattern[loop]);
        }
    }

    public void genTempo(int seed)
    {
        int key = Random.Range(1, 9);
        int arrSize = Random.Range(2, 4);

        //int[] beat = ;


    }
}
