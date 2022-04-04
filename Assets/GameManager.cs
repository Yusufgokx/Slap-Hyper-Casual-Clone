using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    [Header("Scripts")]
    public ChracterControl chracterControl;
    public CameraTracking CameraTracking;
    public TextMeshProUGUI enemyPoints;

    private int enemyCount = 0;
    void Awake()
    {
        Instance = this;
        enemyPoints.text = enemyCount.ToString();

    }
   

    void Update()
    {

    }

    public void TargetText()
    {
        enemyCount++;
        enemyPoints.text = enemyCount.ToString();
    }
}
