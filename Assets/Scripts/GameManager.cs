using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool GamePaused = true;
    [SerializeField] private int _gamepoints;
    public int GamePoints
    {
        get
        {
            return _gamepoints;
        }
        set
        {
            if (value > 0)
            {

                _gamepoints = value;

            }
            else
            {
                _gamepoints = 0;
            }



        }
    }

    void Start() => GamePoints = 0;

    public void SetPause(bool Pause)
    {
        GamePaused = Pause;
    }
}
