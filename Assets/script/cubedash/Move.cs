using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        speed += .0001f;

        transform.position += new Vector3(0f, 0f, -10f) * Time.deltaTime * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject,2);
        }
    }
}
