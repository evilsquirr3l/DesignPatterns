namespace DesignPatterns.Creational.Builder
{
    public class Builder : AbstractBuilder
    {
        private House _house = new House();

        public void BuildRoof()
        {
            _house.Add("Add roof");
        }

        public void BuildBasement()
        {
            _house.Add("Add basement");
        }

        public void BuildStorey()
        {
            _house.Add("Add storey");
        }

        public House GetResult()
        {
            return _house;
        }
    }
}