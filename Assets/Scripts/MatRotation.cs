using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatRotation : MonoBehaviour {

    // Use this for initialization
    public float Max,Min;
    float[] rate;
    public string name;
    public Material[] mat;
	void Start () {
        rate = new float[ mat.Length ];
	}
	
	// Update is called once per frame
	void Update () {
		for(int i=0;i<mat.Length;i++)
        {
              rate[i] += Random.Range(Max,Min) * Time.deltaTime;
          //  mat[i].SetFloat(name, rate);
            mat[i].mainTextureOffset = new Vector2(rate[i], 0);
        }
	}
}
