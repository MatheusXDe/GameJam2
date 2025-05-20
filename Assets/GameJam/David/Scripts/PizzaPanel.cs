using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PizzaPanel : MonoBehaviour
{
    public List<Pizza> pizzaPart = new();

    public List<PizzaType> order = new();
    public int currPizza = -1; Pizza currP;

    public bool hasWin;
    [SerializeField] UnityEvent onUIOrder, onUIPizza;
    private void Start()
    {
        onUIOrder?.Invoke();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.GetComponent<Pizza>().pos)
        {
            case PizzaPosition.Top:
                pizzaPart[0] = collision.GetComponent<Pizza>();
                break;
            case PizzaPosition.Middle:
                pizzaPart[1] = collision.GetComponent<Pizza>();
                break;
            case PizzaPosition.Bottom:
                pizzaPart[2] = collision.GetComponent<Pizza>();
                break;
            default:
                break;
        }
        onUIPizza?.Invoke();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.GetComponent<Pizza>().pos)
        {
            case PizzaPosition.Top:
                pizzaPart[0] = null;
                break;
            case PizzaPosition.Middle:
                pizzaPart[1] = null;
                break;
            case PizzaPosition.Bottom:
                pizzaPart[2] = null;
                break;
            default:
                break;
        }
    }

    void SetPizzaPosition()
    {
        currPizza++;
        switch (currPizza)
        {
            case 0: //Top Pizza

                break;
            case 1: // Center Pizza

                break;
            case 2: // Bottom Pizza

                break;
            default:
                break;
        }
        if (currPizza > 2) currPizza = -1;
    }

    void WinCondition()
    {
        hasWin = pizzaPart[0].type == order[0] && pizzaPart[1].type == order[1] && pizzaPart[2].type == order[2];
    }
}
