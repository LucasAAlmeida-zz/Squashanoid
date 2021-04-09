using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minXPos = 1;
    [SerializeField] float maxXPos = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mouseXPos = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        mouseXPos = Mathf.Clamp(mouseXPos, minXPos, maxXPos);
        transform.position = new Vector2(mouseXPos, transform.position.y);
    }
}
