namespace DesignPatterns.Behavioral_Patterns.Command.Undo
{
    public class Document
    {
        public string Content { get; set; }

        public void MakeBold()
        {
            Content = "<b>" + Content + "</b>";
        }
    }
}