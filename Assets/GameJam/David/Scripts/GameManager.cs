using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Call;

    private void Awake()
    {
        if (Call == null && Call != this)
        {
            Call = this;
            DontDestroyOnLoad(Call.gameObject);
        }
        else Destroy(Call.gameObject);
    }

    public void WinCondition()
    {

    }
}
