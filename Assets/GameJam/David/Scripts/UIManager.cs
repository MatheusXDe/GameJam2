using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text ifWin, order, actual;
    PizzaPanel p;
    private void Start()
    {
        p = GameObject.Find("FinalPizza").GetComponent<PizzaPanel>();
        StartCoroutine(p.FirstInvoke());
    }
    public void HasWin()
    {
        ifWin.text = "Win? " + p.hasWin;
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
