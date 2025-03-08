using UnityEngine;

namespace Observer.CSharpStyle
{
    public class GameManager : MonoBehaviour
    {
        private Player _player;

        private void Awake()
        {
            _player = FindFirstObjectByType<Player>();
            _player.OnHealthChanged += CheckPlayerDeath;
        }

        private void CheckPlayerDeath(int newHealth)
        {
            if (newHealth <= 0)
            {
                Debug.Log("플레이어 사망! 게임 오버.");
            }
        }

        private void OnDestroy()
        {
            _player.OnHealthChanged -= CheckPlayerDeath;
        }
    }
}
