using UnityEngine;

namespace Observer.Interface
{
    public interface IHealthObserver
    {
        void OnHealthChanged(int newHealth);
    }
}