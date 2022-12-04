using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundamentosMovimentacao : MonoBehaviour
{
    private Rigidbody2D PlayerRigidBody;
    private SpriteRenderer sRender;
    
    public float movVelocity;
    public float limitMaxY;                // variaveis limitadoras de posi��o vertical.
    public float limitMinY;
    public float limitMaxX;                // variaveis limitadoras de posi��o horizontal.
    public float limitMinX;


    void Start()
    {
        Application.targetFrameRate = 60;  
        QualitySettings.vSyncCount = 0;


        PlayerRigidBody = GetComponent<Rigidbody2D>();
        sRender = GetComponent<SpriteRenderer>();        
    }
        
    void Update()
    {
        movimentation();
        characterFlip();
    }

    void movimentation()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal"); // atribuimos �s variaveis horizontal e vertical os valores pegos no AxisRaw.
        float vertical = Input.GetAxisRaw("Vertical");
        PlayerRigidBody.velocity = new Vector2(horizontal * movVelocity, vertical * movVelocity); // o vetor do transform do objeto ir� mudar conforme altera as variaveis antes criadas.

        float posY = transform.position.y;    // criamos 2 vari�veis as quais v�o herdar o valor atual da posi��o do transform X e Y
        float posX = transform.position.x;

        // Limit of Movimentation X
        if (transform.position.x > limitMaxX)
        {
            posX = limitMaxX;
        }
        else if (transform.position.x < limitMinX)
        {
            posX = limitMinX;
        }

        // Limit of Movimentation Y
        if (transform.position.y > limitMaxY)       // fazemos um check para verificar se a posi��o atual � maior que o limite pr� definido. Caso seja, a variav�l  de posi��o muda para o valor limite. 
        {
            posY = limitMaxY;

        }
        else if (transform.position.y < limitMinY)
        {
            posY = limitMinY;

        }

        transform.position = new Vector3(posX, posY, 0); // define que a nova posi��o do transform ser� com base no valor das vari�veis criadas anteriormente.

    }

    void characterFlip()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        if(horizontal < 0)
        {
            sRender.flipX = true;
        }
        else
        {
            sRender.flipX = false;
        }
    }

}  
    
    

