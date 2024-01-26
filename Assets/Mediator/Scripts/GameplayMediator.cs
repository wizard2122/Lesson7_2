using UnityEngine;

public class GameplayMediator : MonoBehaviour
{
    [SerializeField] private DefeatPanel _defeatPanel;

    private Level _level;

    public void Initialize(Level level)
    {
        _level = level;
        _level.Defeat += OnLevelDefeat;
    }

    private void OnDestroy()
    {
        _level.Defeat -= OnLevelDefeat;
    }

    private void OnLevelDefeat() => _defeatPanel.Show();

    public void RestartLevel()
    {
        _defeatPanel.Hide();
        _level.Restart();
    }
}
