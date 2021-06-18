using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    //references
    public Player player;
    public TextOnScreenManager textOnScreenManager;

    public void ShowText(string message, int fontsize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        textOnScreenManager.Show( message,  fontsize,  color,  position,  motion,  duration);  
    }
}
