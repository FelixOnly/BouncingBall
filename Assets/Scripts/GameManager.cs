using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  There were paws Felix Only (felixdeveloperkettle@gmail.com)
//  Author :    Felix Only (felixdeveloperkettle@gmail.com) 
//  Date   :    22 July 2021 

public class GameManager : MonoBehaviour
{
	/* This is variable  will help with 
	   understanding when the game are paused */
	public static bool GamePaused = true;
	
	/* This is variable about collecting a point for a player */
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

    void Start() 
	{ 
		// Nullify variable on starting a game 
		GamePoints = 0;
	}

	/* Set variable */
    public void SetPause(bool Pause)
    {
        GamePaused = Pause;
    }
}

//  There were paws Felix Only (felixdeveloperkettle@gmail.com)
//  Author :    Felix Only (felixdeveloperkettle@gmail.com) 
//  Date   :    22 July 2021 
