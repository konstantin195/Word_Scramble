using Word_Scramble;

namespace WordScramble;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new IndexForm());
    }
}
