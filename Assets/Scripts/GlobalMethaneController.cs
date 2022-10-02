using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using static Country;

public class GlobalMethaneController : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public GameObject disaster;
    public float MethaneLevel = 0;
    public float prevMethane = 0;
    public int numberOfDisasters;
    public int lastDisaster = 0;
    List<float> xCoordinates = new List<float>();
    List<float> yCoordinates = new List<float>();
    public void addEmissions(float emission)
    {
        MethaneLevel += emission;
    }

    public void reduceEmissions(float emission)
    {
        MethaneLevel -= emission;
    }

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.ScreenToViewportPoint(Input.mousePosition);
        xCoordinates.Add((float)0.33);
        xCoordinates.Add((float)0.22);
        xCoordinates.Add((float)0.17);
        xCoordinates.Add(0);
        xCoordinates.Add((float)-0.4);
        xCoordinates.Add((float)1.85);
        xCoordinates.Add(1);

        yCoordinates.Add((float)-2.6);
        yCoordinates.Add((float)-2.15);
        yCoordinates.Add((float)-1.8);
        yCoordinates.Add((float)-1.36);
        yCoordinates.Add(-1);
        yCoordinates.Add((float)-1.3);
        yCoordinates.Add((float)-2.6);
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = $"Global CH4: {MethaneLevel}%";
        float numOfDisasters = (MethaneLevel - prevMethane) / 10;
        for(int i = lastDisaster; i < numOfDisasters; i++)
        {
            transform.position = new Vector2(xCoordinates[i], yCoordinates[i]);
            Instantiate(disaster, Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.rotation);
        }
        lastDisaster += (int)numberOfDisasters;
    }
    public void AddMethane(float methaneAddition)
    {
        MethaneLevel += methaneAddition;
    }

    public void DecreaseMethane(float methaneReduction)
    {
        MethaneLevel -= methaneReduction;
    }
}
