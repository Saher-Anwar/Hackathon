using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factory : MonoBehaviour
{
    public float time;
    public float profit;
    public float emission;

    public GameManager manager;

    private float timeElapsed = 0;
    public float timeIntervalInSecondsBeforeAddingProfit = 4f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // time elapsed keep the track of how much time has passed so far
        timeElapsed += Time.deltaTime;

        // if the time elapsed is greater than the time that we specified, we add a certain profit
        if(timeElapsed > timeIntervalInSecondsBeforeAddingProfit)
        {
            // add x amount of profit
        }
        
        manager.globalMethanecontroller.addEmissions(emission*Time.deltaTime);
        manager.BudgetController.AddProfit(profit*Time.deltaTime);
    }
}
