using UnityEngine;
using System.Collections;

public class EarthSpinScript : MonoBehaviour {
    public float speed = 10f;
    public Transform camera;

    public float minDistance;
 
    void Start()
    {
       
    }

    void Update() {
        
        if(distanceOf(camera.position,transform.position)<=minDistance){
            transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
        }
    }

    private float distanceOf(Vector3 v1, Vector3 v2){
        return (v2.x-v1.x)*(v2.x-v1.x)+(v2.y-v1.y)*(v2.y-v1.y)+(v2.z-v1.z)*(v2.z-v1.z);
    }
}