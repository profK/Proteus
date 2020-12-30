namespace Proteus
{
    public class PLabel:HTMLComponent
    {
        public PLabel(string text) : base(MakeHTML(text))
        {
        }

        private static string MakeHTML(string text)
        {
            return "<span>" + text + "</span>";
        }
    }
}