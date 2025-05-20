using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Call;

    [SerializeField] AudioClip[] sfx; // 0:check, 1:error
    [SerializeField] AudioClip bgm;
    [SerializeField] AudioSource[] sources; // 0:sfx, 1:bgm
    private void Awake()
    {
        if (Call == null && Call != this)
        {
            Call = this;
            DontDestroyOnLoad(Call.gameObject);
        }
        else Destroy(Call.gameObject);
    }

    public void PlayMusic()
    {

    }
}
