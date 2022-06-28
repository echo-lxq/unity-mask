using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager
{
    private static GameManager _Instance;
    public static int index;
    public static GameManager Instance{
        get
        {
            if(_Instance == null){
                _Instance = new GameManager();
            }
            return _Instance;
        }
    }
}
