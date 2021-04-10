using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip destroySound;

    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.OnBlockCreated();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(destroySound, Camera.main.transform.position);
        level.OnBlockBroken();
        Destroy(gameObject);
    }
}
