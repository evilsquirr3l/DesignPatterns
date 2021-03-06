namespace DesignPatterns.Behavioral_Patterns.Strategy
{
    public class ImageStorage
    {
        public void Save(string image, IImageEncoder encoder, IImageFilter filter)
        {
            filter.Filter(image);
            encoder.Encode(image);
        }
    }
}