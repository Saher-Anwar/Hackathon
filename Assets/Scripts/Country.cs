using RotaryHeart.Lib.SerializableDictionary;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour
{
    public string CountryName;
    public GameObject factory;
    public GameManager gameManager;

    [Serializable]
    public class FactoryTypes : SerializableDictionaryBase<string, GameObject> { }

    public FactoryTypes factoryTypes;

    public const string lng = "Liquified Natural Gas";
    public const string coalMine = "Coal Mine";

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createNewFactory(string factoryType)
    {
        GameObject instance = Instantiate(factoryTypes[factoryType], Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.rotation);
        instance.transform.position = new Vector3(instance.transform.position.x, instance.transform.position.y, -9);
        AddNewHeadline($"A new {factoryType} factory is being built in {CountryName}. It is estimated to take X amount of years to be made");
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown("space"))
        {
            print("Constructing LNG factory");
            createNewFactory(lng);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            print("Constructing Coal Mine");
            createNewFactory(coalMine);
        }

        Debug.Log("Hovering..");
    }

    public void AddNewHeadline(string message)
    {
        gameManager.newsPanel.AddTickerItem(message);
    }
}
