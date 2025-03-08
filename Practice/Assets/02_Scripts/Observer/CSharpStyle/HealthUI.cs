using UnityEngine;
using UnityEngine.UI;

namespace Observer.CSharpStyle
{
    public class HealthUI : MonoBehaviour
    {
        [SerializeField] private Text healthText;
        private Player _player;

        private void Awake()
        {
            _player = GetComponent<Player>();
            _player.OnHealthChanged += UpdateHealthUI;
        }

        private void UpdateHealthUI(int newHealth)
        {
            healthText.text = newHealth.ToString();
        }

        private void OnDestory()
        {
            _player.OnHealthChanged -= UpdateHealthUI;
        }
    }
}
