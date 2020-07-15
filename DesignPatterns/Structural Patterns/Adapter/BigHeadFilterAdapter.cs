namespace DesignPatterns.Structural_Patterns.Adapter
{
    public class BigHeadFilterAdapter : IFilter
    {
        private BigHeadFilter _bigHeadFilter;

        public BigHeadFilterAdapter(BigHeadFilter bigHeadFilter)
        {
            _bigHeadFilter = bigHeadFilter;
        }

        public void Apply(Image image)
        {
            _bigHeadFilter.Init();
            
            _bigHeadFilter.ApplyFilter(image);
        }
    }
}