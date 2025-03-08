using UnityEngine;
using UnityEngine.UI;

namespace Observer.Interface
{
    public class HealthUI : MonoBehaviour, IHealthObserver
    {
        [SerializeField] private Text healthText;
        private Player _player;

        private void Awake()
        {
            _player = GetComponent<Player>();
            _player.RegisterObserver(this);
        }

        public void OnHealthChanged(int newHealth)
        {
            healthText.text = newHealth.ToString();
        }

        private void OnDestroy()
        {
            _player.UnregisterObserver(this);
        }
    }
}