using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text ifWin, order, actual;
    PizzaPanel p;
    [SerializeField] private GameObject winMenu;
    [SerializeField] private GameObject gameoverMenu;

    private void Start()
    {
        p = GameObject.Find("FinalPizza").GetComponent<PizzaPanel>();
        StartCoroutine(p.FirstInvoke());
    }
    public void HasWin()
    {
        if (p.hasWin)
        {
            //ifWin.text = "Win? " + p.hasWin;
            //p.imageWin.SetActive(true);
            winMenu.SetActive(true);
        }
        else
        {
            //p.imageLose.SetActive(true);
            gameoverMenu.SetActive(true);
        }
           
    }

    public void UIOrder()
    {
        string a = p.order[0].ToString();
        string b = p.order[1].ToString();
        string c = p.order[2].ToString();
        order.text = "Order: " + a + ", " + b + ", " + c;
    }
    public void ActualPizza()
    {
        string a = p.pizzaPart[0].type.ToString();
        string b = p.pizzaPart[1].type.ToString();
        string c = p.pizzaPart[2].type.ToString();
        actual.text = "Actual pizza: " + a + ", " + b + ", " + c; ;
    }
}
