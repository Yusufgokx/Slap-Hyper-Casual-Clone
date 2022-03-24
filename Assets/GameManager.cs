using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    [Header("Scripts")]
    public ChracterControl chracterControl;
    public EnemyControl enemyControl;
    
    void Awake()
    {
        Instance = this;

    }

    void Start()
    {
       
    }

    
    void Update()
    {
        
    }
  

}
