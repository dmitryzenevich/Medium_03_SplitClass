namespace SplitClass
{
    public class Player
    {
        public string Name { get; private set; }
        public float MovementDirectionX { get; private set; }
        public float MovementDirectionY { get; private set; }
        public int Age { get; private set; }
        public float MovementSpeed { get; private set; }
        
        public Weapon Weapon{ get; private set; }

        public Player(Weapon weapon) => Weapon = weapon;
        
        public void Move()
        {
            //Do move
        }

        public void Attack()
        {
            //attack
            Weapon.Shoot();
        }
    }
}