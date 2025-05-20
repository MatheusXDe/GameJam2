using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PizzaPanel : MonoBehaviour
{
    [SerializeField] List<Pizza> pizzaPart = new();
    List<PizzaType> pizzaTypes = new();
    List<PizzaPosition> pizzaPositions = new();

    public int currPizza = -1; Pizza currP;
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
}
