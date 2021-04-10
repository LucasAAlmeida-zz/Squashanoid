using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
    //    float redPigment = Random.Range(0f, 1f);
    //    float greenPigment = Random.Range(0f, 1f);
    //    float bluePigment = Random.Range(0f, 1f);
    //    GetComponent<SpriteRenderer>().color = new Color(redPigment, greenPigment, bluePigment);
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
