using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Player Settings")]

    public float movVelocity;
    public float limitMaxY;                // variaveis limitadoras de posi��o vertical.
    public float limitMinY;
    public float limitMaxX;                // variaveis limitadoras de posi��o horizontal.
    public float limitMinX;

    [Header("Objet Settings")]

    public float objectVelocity;
    public float distanceToDestroy;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
