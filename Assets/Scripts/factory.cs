using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factory : MonoBehaviour
{
    public float time;
    public float profit = 20000;
    public float emission = 0.8f;

    public GameManager manager;

    private float timeElapsed = 0;
    private float timeElapsedForEmission = 0;
    public float timeIntervalInSecondsBeforeAddingProfit = 4f;
    public float timeIntervalInSecondsForAddingEmission = 2f;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameManager.instance;
        manager.BudgetController.budget -= 750000;
    }

    // Update is called once per frame
    void Update()
    {
        // time elapsed keep the track of how much time has passed so far
        timeElapsed += Time.deltaTime;
        timeElapsedForEmission += Time.deltaTime;

        // if the time elapsed is greater than the time that we specified, we add a certain profit
        if (timeElapsed > timeIntervalInSecondsBeforeAddingProfit)
        {
            // add x amount of profit
            manager.BudgetController.AddProfit(profit);
            timeElapsed = 0;
            Debug.Log("Profit");
        }

        if (timeElapsedForEmission > timeIntervalInSecondsForAddingEmission)
        {
            manager.globalMethanecontroller.addEmissions(emission);
            timeElapsedForEmission = 0;
        }
    }
}
