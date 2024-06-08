using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    private PlayerController playerController;

    public static GameManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (_instance == this)
            {
                Destroy(gameObject);
            }
        }
    }

    void Start()
    {
        playerController = CharacterManager.Instance.Player.GetComponent<PlayerController>();
        GameStart();
    }

    void GameStart()
    {
        playerController.ToggleCursor();
        Time.timeScale = 0f;
    }
}
