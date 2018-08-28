using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore.Examples.HelloAR;

public class GameobjectSwitchScript : MonoBehaviour {

    [SerializeField] HelloARController controller;
    public List<GameObject> items;
	
	
	// Update is called once per frame
	void Update ()
    {
        controller.AndyPlanePrefab = items[ObjectSelection.instance.currentSelectedObject];
    }
}
