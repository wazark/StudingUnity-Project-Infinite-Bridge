using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manipularSpritRender : MonoBehaviour
{
    private SpriteRenderer sRender; // necess�rio inicializar o componente primeiro. Recomendado para evitar erros fazemos isto no private e usar o get component para evitar erros.



    void Start()
    {
       sRender = GetComponent<SpriteRenderer>(); // utilizamos o get componente e definimos o componente que queremos pegar. Poderiamos deixar a variavel publica e levar o componente at� a variavel,
                                                 // mas podemos ter alguns erros com isto.

        //sRender.color = Color.red; // cores j� pr� definidas.
        sRender.color = new Color(255, 0, 0); // neste caso podemos utilizar os parametros RGB e colocar a cor que desejamos sem ser as pr� definidas, mas o recomendado � a cria��o de uma
                                              // vari�vel publica da cor que queremos e mudamos ela diretamente no inspector.
        sRender.flipX = true;
        sRender.enabled= true; // ativa ou desativa o componente. diferente do setactive que desativa o objet, este n�o faz isto, apenas o componente. 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
