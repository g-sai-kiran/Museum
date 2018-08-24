using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour {

    // Use this for initialization
    public float speed = 0.1f;
    public Transform[] _camera;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 primaryTouchpad = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
         if (primaryTouchpad.x > 0 || primaryTouchpad.y > 0)
        {
            for(int i=0;i<_camera.Length;i++)
            {
                _camera[i].Translate(_camera[i].forward * (speed * Time.deltaTime));
            }
        }
           

       //  if (primaryTouchpad.x < 0 || primaryTouchpad.y < 0)
         //   _camera.Translate(_camera.forward * -(speed * Time.deltaTime));
    }
}
