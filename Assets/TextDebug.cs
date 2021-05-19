using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDebug : MonoBehaviour
{
    // Start is called before the first frame update
    private Text _text;
    void Start()
    {
        _text = GameObject.FindWithTag("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "Loaded";
    }
}
