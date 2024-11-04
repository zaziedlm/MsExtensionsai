// See https://www.nuget.org/packages/Microsoft.Extensions.AI.AzureAIInference/#readme-body-tab
// https://devblogs.microsoft.com/dotnet/introducing-microsoft-extensions-ai-preview/
using Azure;
using Microsoft.Extensions.AI;
using Common;

// 実行モジュール位置(\bin\Debug\net8.0)からプロジェクトルートの.envファイルを読み込む
EnvLoader.Load();

IChatClient chatClient =
    new Azure.AI.Inference.ChatCompletionsClient(
        new Uri(Environment.GetEnvironmentVariable("GH_INF_URL")!),
        new AzureKeyCredential(Environment.GetEnvironmentVariable("GH_TOKEN")!))
    .AsChatClient(Environment.GetEnvironmentVariable("GH_MODEL"));

Console.WriteLine(await chatClient.CompleteAsync("Hello, how are you?"));