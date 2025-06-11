using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{ 
    private string nome = "text";
    private int vida = 5;
    public float velocidade = 2.5f;
    private bool morto = false;
    private Rigidbody2D rb;
    public float novagravidade = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Name:  \n" + nome);
        Debug.Log("Life \n:" + vida);
        Debug.Log("Speed \n:" + velocidade);
        Debug.Log("is dead \n:" + morto);
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novagravidade;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
