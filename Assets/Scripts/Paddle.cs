using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    float screenWidthInputUnit = 16F;
    [SerializeField]
    float minx = 1F;
    [SerializeField]
    float maxX = 15F;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition.x / Screen.width);
        float mousePosInUnit = Input.mousePosition.x / Screen.width * screenWidthInputUnit;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnit, minx, maxX);
        transform.position = paddlePos;
    }
}
