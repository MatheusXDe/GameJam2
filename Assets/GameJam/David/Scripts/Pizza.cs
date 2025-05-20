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
    [SerializeField] float speed;
    bool move=true;
    PizzaPanel p;
    private void OnEnable()
    {
        p = GameObject.Find("FinalPizza").GetComponent<PizzaPanel>();
        sr = GetComponent<SpriteRenderer>();
        random = Random.Range(0, pizzas.Length);

        sr.sprite = pizzas[random].pizzaSprite;
        type = pizzas[random].type;
    }
    private void Update()
    {
        if (position == p.currPizza) move = false;
        if (p.currPizza ==-1) move = true;
    }
    private void LateUpdate()
    {
        if(move)transform.position = Vector2.MoveTowards(transform.position, destination, speed *Time.deltaTime);
        else return;

        if (transform.position.x == destination.x) Restart();
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
