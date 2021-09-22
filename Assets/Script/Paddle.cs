using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PaddlePos = new Vector3(.5f, transform.position.y, 0f);

        float MousePosInBlock= Input.mousePosition.x / Screen.width * 16;

        PaddlePos.x = Mathf.Clamp(MousePosInBlock, .5f, 15.5f);

        this.transform.position = PaddlePos;
    }
}
