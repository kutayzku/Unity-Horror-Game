using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REDBUTTON : MonoBehaviour
{

    public GameObject boxHolder;
    public bool oneTime = true;
    public float ButonTravel = (float)1;

    public void OnTriggerEnter(Collider other)
    {
        if (oneTime == true)
        {
            boxHolder.SetActive(false);

            // transform.Set(x, y, z, 1);
            //this.gameObject.GetComponent<Transform>.localPosition = Vector3.zero;

            transform.position += new Vector3(0, -1*ButonTravel, 0);
            //Debug.Log("RED buton press");

            oneTime = false;
        }
        

    }

}
