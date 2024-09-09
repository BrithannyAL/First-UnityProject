using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text collectibles;
    public TMP_Text totalCollectibles;

    private int cantidad;
    private int cantidadTotal;
    void Start()
    {
        cantidadTotal = transform.childCount; 
        totalCollectibles.text = cantidadTotal.ToString();
    }

    void Update()
    {
        if (transform.childCount <= 0)
        {
            Debug.Log("WIN");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void AddCollectible()
    {
        cantidad++; //Se va a aumentar la cantidad
        collectibles.text = cantidad.ToString(); //Mostrar la cantidad en el texto
    }
}
