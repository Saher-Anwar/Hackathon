using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factory : MonoBehaviour
{
    public float time;
    public float profit;
    public float emission;

    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        manager.globalMethanecontroller.addEmissions(emission*Time.deltaTime);
        manager.BudgetController.AddProfit(profit*Time.deltaTime);
    }
}
