using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class CuboScript : MonoBehaviour
{
    Rigidbody rb;
    
   
    public float velocidad;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();       
       
    }
    public void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        rb.AddForce(movimiento * velocidad);


    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

    
}
