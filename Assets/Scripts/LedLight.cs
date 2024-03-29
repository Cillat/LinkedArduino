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
        if (Input.GetKeyDown(KeyCode.A))
        {
            serialHandler.Write("0");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            serialHandler.Write("1");
        }
    }

    void OnDataReceived(string message)
    {
        var data = message.Split(
                new string[] { "\n" }, System.StringSplitOptions.None);
        if (data.Length < 2) return;

        try
        {
        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }
    }
}
