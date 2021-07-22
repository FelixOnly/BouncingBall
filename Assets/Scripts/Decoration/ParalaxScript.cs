using UnityEngine;

//  There were paws Felix Only (felixdeveloperkettle@gmail.com)
//  Author :    Felix Only (felixdeveloperkettle@gmail.com) 
//  Date   :    22 July 2021 

public class ParalaxScript : MonoBehaviour
{
    /* This is variable  for set a force of moving for a layer */
    [Range(0f, 0.5f)] public float ParalaxEffect;

    /* Cashing variable on object for easly getting */
    private Material _mat;

    void Start()
    {
        // Cashing the variable on a initial scene
        _mat = GetComponent<SpriteRenderer>().material;
    }

    void Update()
    {
        /* In the game scene will change a texture 
           offset, and because of it will a elusion of 
           moving and a elusion of perspective         */


        // Only when the game is working 
        if (!GameManager.GamePaused)
        {
            // Change a new texture offset varible with ParalaxEffect and Time  
            _mat.mainTextureOffset += new Vector2(ParalaxEffect * Time.deltaTime, 0);
        }

    }
}

//  There were paws Felix Only (felixdeveloperkettle@gmail.com)
//  Author :    Felix Only (felixdeveloperkettle@gmail.com) 
//  Date   :    22 July 2021 