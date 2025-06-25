using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public ParticleSystem efeito;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log("O Jogo está rodando!");
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {
            Debug.Log("Bateu");
            gameManager.perderVida();
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
