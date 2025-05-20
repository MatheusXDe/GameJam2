using UnityEngine;

[CreateAssetMenu(fileName = "New Pizza", menuName = "Scriptable Objects/Pizza")]
public class SO_Pizza : ScriptableObject
{
    public Sprite pizzaSprite;
    public PizzaType type;
}
