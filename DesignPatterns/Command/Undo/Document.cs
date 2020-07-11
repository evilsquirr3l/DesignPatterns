namespace DesignPatterns.Command.Undo
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