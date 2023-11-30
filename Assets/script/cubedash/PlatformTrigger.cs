using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    [SerializeField] GameObject platform;
    [SerializeField] Vector3 platformposition;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlatformSpawner"))
        {
            Instantiate(platform,new Vector3(0f, 0f, 420f),Quaternion.identity);
        }
    }
}
