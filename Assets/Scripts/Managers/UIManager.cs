using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Oestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    public void UpdateScore(int score)
    {
        _scoreText.text = score.ToString();
    }
}
