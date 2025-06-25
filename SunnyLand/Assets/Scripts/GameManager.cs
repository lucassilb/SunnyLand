using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int life = 5;
    public TMP_Text textovida;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ganharVida()
    {
        life++;
        textovida.text = life.ToString();

    }
    public void perderVida()
    {
        life--;
        textovida.text = life.ToString();

    }
}