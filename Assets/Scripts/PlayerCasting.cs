using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float distanceFromTarget;
    [SerializeField] float toTarget;

    // Bit shift the index of the layer (8) to get a bit mask
    //int layerMask = 1 << 8;
    // This casts rays only against colliders in layer 8.

    LayerMask layerMask;

    private void Start()
    {
        layerMask = LayerMask.GetMask("MainChar");
        // But to collide against everything except layer 8, use the ~ operator because it inverts a bitmask.
        layerMask = ~layerMask;
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            
            toTarget = hit.distance;
            distanceFromTarget = toTarget;
            
            //if (hit.collider != null){Debug.Log("Hit " + hit.collider.gameObject.name, hit.collider.gameObject);}
        }
        else { Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 10, Color.white); }
    }
}
