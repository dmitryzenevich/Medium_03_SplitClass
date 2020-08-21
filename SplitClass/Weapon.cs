using System;
using System.Threading;
using System.Threading.Tasks;

namespace SplitClass
{
    public class Weapon
    {
        private float _cooldown;
        private float _damage;
        private bool _isReloading = false;

        public float Cooldown => _cooldown;
        public float Damage => _damage;
        public bool IsReloading => _isReloading;

        public Weapon(float cooldown, float damage)
        {
            _cooldown = cooldown;
            _damage = damage;
        }

        public void Shoot()
        {
            if (IsReloading)
            {
                Console.WriteLine("Reloading!");   
                return;
            }

            Console.WriteLine($"Shoot! Damage: {Damage}");
            
            _isReloading = true;
            ReloadingAsync();
        }

        private async void ReloadingAsync() => await Task.Run(() => Reloading());

        private void Reloading()
        {
            Thread.Sleep((int) (Cooldown * 1000));
            _isReloading = false;
        }
    }
}