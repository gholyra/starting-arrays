using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vetores : MonoBehaviour
{

    private string[] personagens = new string[] {"Baldur", "Anduim", "Rexxar", "Frodo", "Kratos"};
    private int[] numeros = new int[5];
    private bool[] booleanos = new bool[5] {true, false, false, true, true} ;

    // Start is called before the first frame update
    void Start()
    {
        numeros[0] = 5;
        numeros[1] = 10;
        numeros[2] = 1;
        numeros[3] = 7;
        numeros[4] = 32;

        for (int i = 0; i < personagens.Length; i++)
        {
            print(personagens[i]);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
