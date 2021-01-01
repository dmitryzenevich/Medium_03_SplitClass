namespace SplitClass
{
    public class Player : Character, IMoveable
    {
        public float MovementDirectionX { get; private set; }
        public float MovementDirectionY { get; private set; }
        public float MovementSpeed { get; private set; }

        public Weapon Weapon { get; private set; }

        public Player(Weapon weapon) => Weapon = weapon;

        //Do move
        public void Move() { }

        //Attack
        public void Attack() => Weapon.Shoot();
    }
}