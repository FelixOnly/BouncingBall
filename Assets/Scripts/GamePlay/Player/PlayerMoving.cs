using UnityEngine.SceneManagement;
using UnityEngine;


//  There were paws Felix Only (felixdeveloperkettle@gmail.com)
//  Author :    Felix Only (felixdeveloperkettle@gmail.com) 
//  Date   :    21 July 2021 

public class PlayerMoving : MonoBehaviour
{

    /* This variable will help know about 
       touching a player againt ground   */
    [SerializeField] private Transform _groundcheck;

    /* This force how much far will jump player */
    [SerializeField] private int _jumpforce;

    /* This is layer of game where objects will ground
       for a system of checking, a ground             */
    [SerializeField] private LayerMask _groundlayer;


    /* Caching a rigidbody component for comfort and process time */
    private Rigidbody2D _rigibody;


    /* This is variable  will active only when player on a Ground layer */
    private bool _isground;


    private void Start()
    {
        // Caching a rigibody component in variable
        _rigibody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        /* Locking position for moving the player on X
           as well locking a rotation and make the player
           moving only Up and Down                        */

        transform.position = new Vector3(0, transform.position.y, transform.position.z);
        transform.rotation = new Quaternion(0f, 0f, 0f, 0f);


        // We creating circle and checking a player, he are on ground or no 
        _isground = Physics2D.OverlapCircle(_groundcheck.position, 0.5f, _groundlayer);


        // Jump if we pressing an Up arrow and only if a game working right now 
        if (Input.GetKey(KeyCode.UpArrow) && !GameManager.GamePaused)
        {
            Jump();
        }
    }


    public void Jump()
    {

        if (_isground)
        {
            // Up velocity of player for making jump 
            _rigibody.velocity = Vector2.up * _jumpforce;
        }

    }

    public void Die()
    {
        /* Set a game on pause and reloading a level */
        GameManager.GamePaused = true;
        SceneManager.LoadScene(Application.loadedLevel);
    }


}

//  There were paws Felix Only (felixdeveloperkettle@gmail.com)
//  Author :    Felix Only (felixdeveloperkettle@gmail.com) 
//  Date   :    21 July 2021 