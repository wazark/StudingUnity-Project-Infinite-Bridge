using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundamentos : MonoBehaviour
{
    /*declaramos as vari�veis aqui.
    A ordem que executamos � chamado de Fluxo.
    as vari�veis ficam: tipoInforma��o    nomeVari�vel        
     */

    //Tipos de vari�veis:
    int inteiro = 100;                // uma vari�vel do tipo int armazena n�meros inteiros, seja negativo ou positivo,
                                      // ela tamb�m possui um limite m�ximo de valor: -2.147.483.648 at� 2.147.483.648.

    float flutuante = 1.5f;            // ponto flutuante, n�mero com casas decimais, por�m usamos o PONTO como separador
                                       // e n�o a v�rgula. Necess�rio colocar o f na frente do valor para identificar que � float. O valor m�ximo +e 10^(elevado a)38.

    bool isBoleano = true;              // valor l�gico, s� tem 2 poss�veis retornos. Verdadeiro ou Falso. por boa pr�tica toda vari�vel bool come�a com "is".

    string texto = "Hello World 1.0";  // O string armazena qualquer valor alpha num�rico, desde que esteja dentro das aspas. 

    // Start is called before the first frame update
    void Start() // s�o chamados de m�todos ou fun��es. 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
