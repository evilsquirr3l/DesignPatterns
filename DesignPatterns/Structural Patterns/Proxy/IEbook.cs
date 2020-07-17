namespace DesignPatterns.Structural_Patterns.Proxy
{
    public interface IEbook
    {
        void Load();

        void Show();

        string GetFileName();
    }
}