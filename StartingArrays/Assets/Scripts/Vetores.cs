using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vetores : MonoBehaviour
{

    private string[] personagens = new string[] {"Baldur", "Anduim", "Rexxar", "Frodo", "Kratos"};
    private string[] arsenalArmas = new string[10];
    [SerializeField] private string[] armas;
    [SerializeField] private string[] classes;
    //private int[] numeros = new int[5];
    //private bool[] booleanos = new bool[5] {true, false, false, true, true} ;

    // Start is called before the first frame update
    void Start()
    {
        //print(personagens[1]);
        //personagens[1] = "CJ";
        //print(personagens[1]);
        //numeros[0] = 5;
        //numeros[1] = 10;
        //numeros[2] = 1;
        //numeros[3] = 7;
        //numeros[4] = 32;
        AdicionarArmasNoInventario(armas);

        //for (int i = 0; i < personagens.Length; i++)
        //{
        //    print(personagens[i]);
        //}
        //foreach (string personagem in personagens)
        //{
        //    print(personagem);
        //}

    }

    private void AdicionarArmasNoInventario(string[] armas)
    {
        for (int i = 0; i < armas.Length; i++)
        {
            arsenalArmas[i] = armas[i];
            //print("A arma " + armas[i] + " está sendo adicionada ao arsenal de armas.");
            print($"A arma {armas[i]} está sendo adicionada ao arsenal de armas.");
        }

        print("Este é o seu arsenal de armas atual.");

        for (int i = 0; i < arsenalArmas.Length; i++)
        {
            print(arsenalArmas[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
