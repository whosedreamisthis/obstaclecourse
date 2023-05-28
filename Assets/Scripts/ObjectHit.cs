using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] Color baseColor;

    void Start()
    {
        baseColor = GetComponent<MeshRenderer>().material.color;
    }
    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log("collided with wall");
        //GetComponent<MeshRenderer>().material = collidedMaterial;
        if (other.transform.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

    }
    private void OnCollisionExit(Collision other)
    {
        /*if (other.transform.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = baseColor;
        }*/
    }
}
