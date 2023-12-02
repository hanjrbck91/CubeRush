using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] Vector3 speed;
    [SerializeField] TMProButton button;
    
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(speed * Time.deltaTime);
    }
}
