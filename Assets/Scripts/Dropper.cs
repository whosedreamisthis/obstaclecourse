using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float delay;
    MeshRenderer mr;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Drop());
        mr = GetComponent<MeshRenderer>();
        mr.enabled = false;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    IEnumerator Drop()
    {
        yield return new WaitForSeconds(delay);
        rb.useGravity = true;
        mr.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
