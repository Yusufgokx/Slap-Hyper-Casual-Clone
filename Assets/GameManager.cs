using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    [Header("Scripts")]
    public ChracterControl chracterControl;
    
    
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
