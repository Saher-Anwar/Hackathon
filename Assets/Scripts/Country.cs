using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour
{
    public string CountryName;
    public GameObject factory;
    public Dictionary<string, GameObject> factoryTypes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createNewFactory()
    {
        Instantiate(factory, Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.rotation);
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown("space"))
        {
            print("Constructing LNG factory");
            createNewFactory();
        }
    }
}
