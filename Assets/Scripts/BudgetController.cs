using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BudgetController : MonoBehaviour
{
    public float budget = 100;
    public TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = $"Budget: ${budget}";
    }

    public void AddProfit(float profit)
    {
        Debug.Log($"budget {budget} incremented by {profit}");
        budget += profit;
    }

    public void SubtractLoss(float loss)
    {
        budget -= loss;
    }
}
