using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleRotation : MonoBehaviour
{
 float PlanetRotateSpeed = -25.0f;
 float OrbitSpeed = 10.0f;

 void Update()
{
    transform.Rotate(transform.up * PlanetRotateSpeed * Time.deltaTime);
    transform.RotateAround(Vector3.zero, Vector3.up, OrbitSpeed * Time.deltaTime);
} 

}
