namespace DependencyInversion
{
    public class Creature
    {
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}