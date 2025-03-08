using UnityEngine;


namespace Observer.Interface
{
    public class GameManager : MonoBehaviour, IHealthObserver
    {
        private Player _player;

        private void Awake()
        {
            _player = FindFirstObjectByType<Player>();
            _player.RegisterObserver(this);
        }

        public void OnHealthChanged(int newHealth)
        {
            if (newHealth <= 0)
            {
                Debug.Log("플레이어 사망! 게임 오버.");
            }
        }

        private void OnDestroy()
        {
            _player.UnregisterObserver(this);
        }
    }
}
