using System.Collections;
using UnityEngine;

//  There were paws Felix Only (felixdeveloperkettle@gmail.com)
//  Author :    Felix Only (felixdeveloperkettle@gmail.com) 
//  Date   :    22 July 2021 

public class SpawnerPlatforms : MonoBehaviour
{
    /* This is variable for creating platforms */
    public GameObject Platform;

    private void Start()
    {
        // Starting coroutine for spawning platforms
        StartCoroutine(Spawning());
    }
    private IEnumerator Spawning()
    {
        /* Creating while where the game will spawning
           all time platforms with a little pause      */
        while (true)
        {
            // Only if the game right now working 
            if (!GameManager.GamePaused)
            {
                // Pause on 2 second 
                yield return new WaitForSeconds(2f);

                // Spawning platform on random range with 0 before 2 on Y coordinate
                Instantiate(
                    Platform,
                    new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 2), 0f),
                    Quaternion.identity
                    );
            }

            // Pause for end of frame
            yield return new WaitForEndOfFrame();

        }

    }
}

//  There were paws Felix Only (felixdeveloperkettle@gmail.com)
//  Author :    Felix Only (felixdeveloperkettle@gmail.com) 
//  Date   :    22 July 2021 
