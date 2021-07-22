using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAction : MonoBehaviour
{
    [SerializeField] private int _movingforce;
    private Rigidbody2D _rigibody;
    private void Update()
    {

        if (!GameManager.GamePaused)
        {
            _rigibody.velocity = Vector2.left * _movingforce;
        }
    }
    private void Start()
    {
        _rigibody = GetComponent<Rigidbody2D>();
        StartCoroutine(DiewithTime());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().GamePoints++;
        }
    }


    private IEnumerator DiewithTime()
    {
        while (GameManager.GamePaused)
        {
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(4f);
        Destroy(this.gameObject);
    }


}

