using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) //Comprueba una colición y lo guarda en la variable que tiene la información con el objeto que ha colicionado
    {
        if (collision.transform.CompareTag("Player"))
        {
            FindAnyObjectByType<GameManager>().AddCollectible(); //Se llama el método de game manager
            Destroy(gameObject);
        }
    }
}
