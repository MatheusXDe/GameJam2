using UnityEngine;

public enum PizzaType
{
    Veggies, Pepperoni, Shrimp, Mexican
}
public enum PizzaPosition
{
    Top,Middle,Bottom
}
public class Pizza : MonoBehaviour
{
    [SerializeField] SO_Pizza[] pizzas;
    [SerializeField] Vector2 destination;
    public PizzaType type;
    public PizzaPosition pos;
    SpriteRenderer sr;
    int random;
    [SerializeField] int position;
    private void OnEnable()
    {
        sr = GetComponent<SpriteRenderer>();
        random = Random.Range(0, pizzas.Length);

        sr.sprite = pizzas[random].pizzaSprite;
        type = pizzas[random].type;
    }
    private void LateUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, destination, 10f*Time.deltaTime);
        if (transform.position.x ==destination.x) Restart();
    }
    void Restart()
    {
        transform.position = new Vector2(-destination.x, transform.position.y);
        sr = GetComponent<SpriteRenderer>();
        random = Random.Range(0, pizzas.Length);

        sr.sprite = pizzas[random].pizzaSprite;
        type = pizzas[random].type;
    }
}
