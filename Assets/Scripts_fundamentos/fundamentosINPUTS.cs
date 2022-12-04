using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class fundamentosINPUTS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Inputs que retornam valores boleanos

       /* if (Input.GetButton("Fire1"))
        {
            print("Apertando o bot�o fire1");  // Este modo enquanto estiver apertando o bot�o, a l�gica vai ser executada a cada frame.
        }
       */
        if(Input.GetButtonDown("Fire1"))
        {
            print("Apertei o bot�o fire1"); // Esta l�gica ir� executar uma �nica vez, mesmo que eu mantenha o bot�o apertado.             
        }

        if(Input.GetButtonUp("Fire1"))
        {
            print("Soltei o bot�o fire1"); // Este m�todo igualmente ao anterior, ir� ser executado uma �nica vez a cada a��o feita. ou seja, se soltar o bot�o, vai ser feito uma unica vez, se apertar o bot�o e soltar novamente, sera executado uma �nica vez novamente.
        }

        // Inputs que retornam valores float

        
          //  print(Input.GetAxis("Horizontal")); // � sensivel ao anal�gico. Desta forma ele vai de 0 a +1 ou 0 a -1.
        
        
        
           print(Input.GetAxisRaw("Vertical")); // n�o � sensivel ao anal�gico. Vai dar resultado 0 ou 1 / 0 ou -1.
        

        // Podemos utilizar estes valores do GetAxis para multiplicar ao valor de velocidade de movimento de um personagem.

        //E quando o jogo � espec�fico para computador e � necess�rio configurar v�rias t�clas, podemos utilizar o Keycode, como nos estudos passados.


        if(Input.GetKeyDown(KeyCode.Escape)) // tamb�m possui o getkey UP e GetKey como os demais exemplos
        {
            print("Apertei Esc");
        }

        // E para o Mouse, podemos usar:

        if(Input.GetMouseButtonDown(1)) // colocamos no valor intege o bot�o que for pressionado (0 - Esquerda, 1 Direita e 2 Scroll do mouse (para saber que apertou e n�o que rodou o scroll)). E tamb�m possui o GetMouseButton UP e GetMouseButton.
        {
            print("apertei o botao 1");
        }


    }
}
