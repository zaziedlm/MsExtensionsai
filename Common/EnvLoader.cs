namespace Common;

public static class EnvLoader
{
    /// <summary>
    /// アプリケーションのベースディレクトリから相対パスを使用して
    /// .envファイルを読み込み、環境変数を設定します。
    /// </summary>
    public static void Load()
    {
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        
        // string relativePath = Path.Combine("..", "..", "..", ".env");    // for each project.
        string relativePath = Path.Combine("..", "..", "..", "..", ".env");   // for solution level.
        string envPath = Path.GetFullPath(Path.Combine(baseDirectory, relativePath));
        DotNetEnv.Env.Load(envPath);
    }
}
