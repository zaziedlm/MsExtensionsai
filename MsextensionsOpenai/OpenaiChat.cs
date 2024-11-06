using OpenAI;
using Microsoft.Extensions.AI;
using Common;

// 実行モジュール位置(\bin\Debug\net8.0)からプロジェクトルートの.envファイルを読み込む
EnvLoader.Load();

IChatClient chatClient =
    new OpenAIClient(Environment.GetEnvironmentVariable("OPENAI_API_KEY")!)
    .AsChatClient(Environment.GetEnvironmentVariable("OPENAI_MODEL")!);

var response = await chatClient.CompleteAsync("Hello, What is AI?");

Console.WriteLine(response.Message);
