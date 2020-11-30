using UnityEngine;
using UnityEngine.SceneManagement;

public class Skin_changer : MonoBehaviour
{


    public void Equip1()
    {

        if (Shop.isBought1 == true)
        {
            PlayerMovement.skin1Equipped = true;
            PlayerMovement.skin2Equipped = false;
            PlayerMovement.skin3Equipped = false;
            PlayerMovement.skin4Equipped = false;
            PlayerMovement.skin5Equipped = false;
            Debug.Log("SKIN 1 EQUIPPED");
        }
        else { Debug.Log("NEMÁŠ KOUPENÉ"); }
    }

    public void Equip2()
    {
        if (Shop.isBought2 == true)
        {
            PlayerMovement.skin1Equipped = false;
            PlayerMovement.skin2Equipped = true;
            PlayerMovement.skin3Equipped = false;
            PlayerMovement.skin4Equipped = false;
            PlayerMovement.skin5Equipped = false;
            Debug.Log("SKIN 2 EQUIPPED");
        }
        else { Debug.Log("NEMÁŠ KOUPENÉ 2"); }
    }

    public void Equip3()
    {
        if (Shop.isBought3 == true)
        {
            PlayerMovement.skin1Equipped = false;
            PlayerMovement.skin2Equipped = false;
            PlayerMovement.skin3Equipped = true;
            PlayerMovement.skin4Equipped = false;
            PlayerMovement.skin5Equipped = false;
            Debug.Log("SKIN 3 EQUIPPED");
        }
        else { Debug.Log("NEMÁŠ KOUPENÉ 3"); }
    }

    public void Equip4()
    {
        if (Shop.isBought4 == true)
        {
            PlayerMovement.skin1Equipped = false;
            PlayerMovement.skin2Equipped = false;
            PlayerMovement.skin3Equipped = false;
            PlayerMovement.skin4Equipped = true;
            PlayerMovement.skin5Equipped = false;
            Debug.Log("SKIN 4 EQUIPPED");
        }
        else { Debug.Log("NEMÁŠ KOUPENÉ 4"); }
    }
    public void Equip5()
    {
        if (Shop.isBought5 == true)
        {
            PlayerMovement.skin1Equipped = false;
            PlayerMovement.skin2Equipped = false;
            PlayerMovement.skin3Equipped = false;
            PlayerMovement.skin4Equipped = false;
            PlayerMovement.skin5Equipped = true;
            Debug.Log("SKIN 5 EQUIPPED");
        }
        else { Debug.Log("NEMÁŠ KOUPENÉ 5"); }
    }



    public void TestSkins()
    {
        SceneManager.LoadScene("shop");
    }
    public void TestSkins2()
    {
        SceneManager.LoadScene("lvl_select");
    }
}