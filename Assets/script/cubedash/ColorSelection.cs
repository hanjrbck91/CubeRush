using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelection : MonoBehaviour
{
    [SerializeField] GameObject cube;
    // Start is called before the first frame update

    public void OnButtonClick()
    {
        cube.GetComponent<Renderer>().material.color = gameObject.GetComponent<Image>().color;
        Debug.Log("cube color Changed:" + gameObject.GetComponent<Image>().color);
    }
}
