using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    Camera _camera;

    // Start is called before the first frame update
    void OnEnable()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
        gameObject.transform.LookAt(2 * transform.position - _camera.gameObject.transform.position);    
    }
}
