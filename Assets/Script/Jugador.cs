using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;

    private void Awake() //Es como el update, pero solo al inicio
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal*speed, rb.velocity.y, moveVertical*speed); //Vecto de movimeinto

        rb.velocity = movement; //Se le asigna el vector a la velicidad
    }
}
