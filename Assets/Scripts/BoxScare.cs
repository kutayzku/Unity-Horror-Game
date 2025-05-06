using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScare : MonoBehaviour
{

    public GameObject boxHolder;
    public void OnTriggerEnter(Collider other)
    {
        boxHolder.SetActive(false);
    }

}
