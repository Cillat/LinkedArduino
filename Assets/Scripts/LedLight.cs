using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedLight : MonoBehaviour
{

    public SerialHandler serialHandler;

    // Start is called before the first frame update
    void Start()
    {
        serialHandler.OnDataReceived += OnDataReceived;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            serialHandler.Write("0");
        }
        if (Input.GetKey(KeyCode.S))
        {
            serialHandler.Write("1");
        }
    }
}
