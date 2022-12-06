using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D PlayerRigidBody;
    private SpriteRenderer sRender;
    private GameController _GameController;
    
    


    void Start()
    {
        Application.targetFrameRate = 60;  
        QualitySettings.vSyncCount = 0;


        PlayerRigidBody = GetComponent<Rigidbody2D>();
        sRender = GetComponent<SpriteRenderer>();      
        
        _GameController=FindObjectOfType(typeof(GameController)) as GameController; // acessa a outra classe e faz a convers�o.
    }
        
    void Update()
    {
        movimentation();
        
    }

    void movimentation()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal"); // atribuimos �s variaveis horizontal e vertical os valores pegos no AxisRaw.
        float vertical = Input.GetAxisRaw("Vertical");
        PlayerRigidBody.velocity = new Vector2(horizontal * _GameController.movVelocity, vertical * _GameController.movVelocity); // o vetor do transform do objeto ir� mudar conforme altera as variaveis antes criadas.

        float posY = transform.position.y;    // criamos 2 vari�veis as quais v�o herdar o valor atual da posi��o do transform X e Y
        float posX = transform.position.x;

        // Limit of Movimentation X
        if (transform.position.x > _GameController.limitMaxX)
        {
            posX = _GameController.limitMaxX;
        }
        else if (transform.position.x < _GameController.limitMinX)
        {
            posX = _GameController.limitMinX;
        }

        // Limit of Movimentation Y
        if (transform.position.y > _GameController.limitMaxY)       // fazemos um check para verificar se a posi��o atual � maior que o limite pr� definido. Caso seja, a variav�l  de posi��o muda para o valor limite. 
        {
            posY = _GameController.limitMaxY;

        }
        else if (transform.position.y < _GameController.limitMinY)
        {
            posY = _GameController.limitMinY;

        }

        transform.position = new Vector3(posX, posY, 0); // define que a nova posi��o do transform ser� com base no valor das vari�veis criadas anteriormente.

        
    }

    void OnTriggerEnter2D()
    {        
        Debug.LogError("GameOver");
        
    }
}  
    
    

