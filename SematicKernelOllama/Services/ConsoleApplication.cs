using Microsoft.Extensions.Logging;

namespace SematicKernelOllama.Services;

public class ConsoleApplication
{
    private readonly IChatService _chatService;
    private readonly ILogger<ConsoleApplication> _logger;

    public ConsoleApplication(IChatService chatService, ILogger<ConsoleApplication> logger)
    {
        _chatService = chatService;
        _logger = logger;
    }

    public async Task RunAsync()
    {
        _logger.LogInformation("Starting Semantic Kernel with Ollama chat application");
        
        // Create a history to store the conversation
        var history = _chatService.CreateNewChatHistory();

        // Initiate a back-and-forth chat
        string? userInput;
        do {
            // Collect user input
            Console.Write("User > ");
            userInput = Console.ReadLine();
            
            if (string.IsNullOrEmpty(userInput))
                break;

            try
            {
                // Get the response from the AI
                var result = await _chatService.GetChatCompletionAsync(history, userInput);

                // Print the results
                Console.WriteLine("Assistant > " + result.Content);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing chat completion");
                Console.WriteLine("Assistant > Sorry, I encountered an error processing your request.");
            }
            
        } while (userInput is not null);
        
        _logger.LogInformation("Chat session ended");
    }
}