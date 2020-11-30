using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditorInternal;

public class Shop : MonoBehaviour
{
    public static int money = 100;
    public int cost;
    public GameObject BuyItemBtn;
    public GameObject NoMoneyTxt;
    public GameObject AlreadyOwnedTxt;

    public static bool isBought1 = false;
    public static bool isBought2 = false;
    public static bool isBought3 = false;
    public static bool isBought4 = false;
    public static bool isBought5 = false;

   

    public void BuyItem1()
    {
        cost = 10;
        if (money >= cost && isBought1 != true)
        {
            money -= cost;
            isBought1 = true;
            BuyItemBtn.GetComponent<Button>().interactable = false;
        }
        else if (money < cost)
        {
            StartCoroutine(TextShow());
        }
        else if (isBought1 == true)
        {
            StartCoroutine(TextShow2());
        }
        
    }


    public void BuyItem2()
    {
        cost = 10;
        if (money >= cost && isBought2 != true)
        {
            money -= cost;
            isBought2 = true;
            BuyItemBtn.GetComponent<Button>().interactable = false;
        }
        else if (money < cost)
        {
            StartCoroutine(TextShow());
        }
        else if (isBought2 == true)
        {
            StartCoroutine(TextShow2());
        }
    }
    public void BuyItem3()
    {
        cost = 10;
        if (money >= cost && isBought3 != true)
        {
            money -= cost;
            isBought3 = true;
            BuyItemBtn.GetComponent<Button>().interactable = false;
        }
        else if (money < cost)
        {
            StartCoroutine(TextShow());
        }
        else if (isBought3 == true)
        {
            StartCoroutine(TextShow2());
        }
    }
    public void BuyItem4()
    {
        cost = 10;
        if (money >= cost && isBought4 != true)
        {
            money -= cost;
            isBought4 = true;
            BuyItemBtn.GetComponent<Button>().interactable = false;
        }
        else if (money < cost)
        {
            StartCoroutine(TextShow());
        }
        else if (isBought4 == true)
        {
            StartCoroutine(TextShow2());
        }
    }
    public void BuyItem5()
    {
        cost = 10;
        if (money >= cost && isBought5 != true)
        {
            money -= cost;
            isBought5 = true;
            BuyItemBtn.GetComponent<Button>().interactable = false;
        }
        else if (money < cost)
        {
            StartCoroutine(TextShow());
        }
        else if (isBought5 == true)
        {
            StartCoroutine(TextShow2());
        }
    }

    public void TestSkins() 
    {
        SceneManager.LoadScene("skins");
    }


    IEnumerator TextShow()
    {
        NoMoneyTxt.SetActive(true);
        yield return new WaitForSeconds(2f);
        NoMoneyTxt.SetActive(false);
    }

    IEnumerator TextShow2()
    {
        AlreadyOwnedTxt.SetActive(true);
        yield return new WaitForSeconds(2f);
        AlreadyOwnedTxt.SetActive(false);
    }
}
