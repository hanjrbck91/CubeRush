using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    [SerializeField] GameObject platform;
    [SerializeField] Vector3 platformposition;
    [SerializeField] GameObject ground;
    [SerializeField] GameObject currentPlatform;
    [SerializeField] GameObject oldplatform;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlatformSpawner"))
        {
            // Generate random hue and saturation values
            float randomHue = Random.value;

            // Create a color using the random hue and saturation, and set it as the ground color
            ground.GetComponent<Renderer>().material.color = Color.HSVToRGB(randomHue, 1f, 1f);

            currentPlatform = Instantiate(platform, new Vector3(0f, 0f, 380f), Quaternion.identity);
             oldplatform = currentPlatform;

        }
    }

    private void Update()
    {
        Destroy(oldplatform,20f);
    }


}
