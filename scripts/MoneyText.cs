using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
{
    Text moneyTxt;

    private void Start()
    {
        moneyTxt = GetComponent<Text>();
    }
    private void Update()
    {
        moneyTxt.text = Shop.money.ToString();
    }
}
