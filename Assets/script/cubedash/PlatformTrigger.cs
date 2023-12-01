using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    [SerializeField] GameObject platform;
    [SerializeField] Vector3 platformposition;
    [HideInInspector]
    [SerializeField] int numberOfPlatforms;
    [SerializeField] GameObject ground;

    private void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlatformSpawner"))
        {
            
            numberOfPlatforms++;

            if(numberOfPlatforms % 5 == 0)
            {
                ground.GetComponent<Renderer>().material.color= Color.green;
            }
            else if(numberOfPlatforms % 2 == 0)
            {
                ground.GetComponent<Renderer>().material.color= Color.red;
            }
            else if (numberOfPlatforms % 3 == 0)
            {
                ground.GetComponent<Renderer>().material.color = Color.white;
            }else if(numberOfPlatforms % 7 == 0)
            {
                ground.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if(numberOfPlatforms%6 == 0)
            {
                ground.GetComponent<Renderer>().material.color = Color.cyan;
            }

            Instantiate(platform, new Vector3(0f, 0f, 380f), Quaternion.identity);

        }
    }
    
    
}
