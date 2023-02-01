using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSound : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        GetComponent<AudioSource>().Play();
    }
}
