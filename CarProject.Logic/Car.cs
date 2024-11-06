namespace CarProject.Logic
{
    public class Car
    {
        #region fields
        private int _gear = 0;
        private int _speed = 0;
        private IDice _dice;
        public int Speed
        {
            get
            {
                return _speed;
            }
        }
        public int Gear
        {
            get
            {
                return _gear;
            }
            set
            {
                if (value < 0 || value > 6)
                    throw new ArgumentException("Gear should be between 0 and 6");
                else
                    _gear = value;
            }
            #endregion fields
        }
        public Car() : this(new DefaultDice())
        {
        }
        public Car(IDice dice)
        {
            _dice = dice;
        }
        public void Accelerate()
        {
            _dice.Roll();
            _speed = Gear * 10 * _dice.Dots;

        }
    }
}