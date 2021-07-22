using UnityEngine;
using UnityEngine.UI;

//  There were paws Felix Only (felixdeveloperkettle@gmail.com)
//  Author :    Felix Only (felixdeveloperkettle@gmail.com) 
//  Date   :    21 July 2021 


public class PointCounterScript : MonoBehaviour
{
    // This a Text object will show how much many a points player have 
    [SerializeField] private Text PointText;

    // Cacheing an object of manager for easy getting 
    // and as well use not so many procces force  
    private GameManager _gamemanager;

    void Start()
    {
        // Cacheing the Game Manager in variable
        _gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        // In a per second we will updating how much many a points player have
        PointText.text = $": {_gamemanager.GamePoints}";
    }

}

//  There were paws Felix Only (felixdeveloperkettle@gmail.com)
//  Author :    Felix Only (felixdeveloperkettle@gmail.com) 
//  Date   :    21 July 2021 