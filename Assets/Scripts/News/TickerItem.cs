using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;

public class TickerItem : MonoBehaviour
{
    float tickerWidth;
    float pixelsPerSecond;
    RectTransform rectTransform;

    public float GetXPosition { get { return rectTransform.anchoredPosition.x; } }
    public float GetWidth { get { return rectTransform.rect.width; } }

    public void Initialize(float tickerWidth, float pixelsPerSecond, string message)
    {
        this.tickerWidth = tickerWidth;
        this.pixelsPerSecond = pixelsPerSecond;
        rectTransform = GetComponent<RectTransform>();
        GetComponent<TextMeshProUGUI>().text = message + "  |  ";
    }

    // Update is called once per frame
    void Update()
    {
        rectTransform.position += Vector3.left * pixelsPerSecond * Time.deltaTime;
        if(GetXPosition <= 0 - tickerWidth - GetWidth)
        {
            Destroy(gameObject);
        }
    }
}
