using RotaryHeart.Lib.SerializableDictionary;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour
{
    public string CountryName;
    public GameObject factory;

    [Serializable]
    public class FactoryTypes : SerializableDictionaryBase<string, GameObject> { }

    public FactoryTypes factoryTypes;

    public const string lng = "Liquified Natural Gas";
    public const string coalMine = "Coal Mine";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createNewFactory(string factoryType)
    {
        Instantiate(factoryTypes[factoryType], Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.rotation);
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
}
