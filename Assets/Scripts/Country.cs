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

        StartCoroutine(DisplayNewMessage("Global sea levels have risen by 2 inches in the past 2 years", 13));
        StartCoroutine(DisplayNewMessage($"Hurricane Ian hits Florida. It serves as an example of the effect of climate change and how it will only get worse", 23f));
        AddNewHeadline($"A new {factoryType} factory is being built in {CountryName}. It is estimated to produce {instance.GetComponent<factory>().emission * 2} levels of Methane per Quarter! ");
        //AddNewHeadline();
    }

    IEnumerator DisplayNewMessage(string message, float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        AddNewHeadline(message);
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
