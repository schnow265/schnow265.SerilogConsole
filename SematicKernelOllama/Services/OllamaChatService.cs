using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

namespace SematicKernelOllama.Services;

public class OllamaChatService : IChatService
{
    private readonly Kernel _kernel;
    private readonly IChatCompletionService _chatCompletionService;
    private readonly ILogger<OllamaChatService> _logger;

    public OllamaChatService(Kernel kernel, ILogger<OllamaChatService> logger)
    {
        _kernel = kernel;
        _chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
        _logger = logger;
    }

    public ChatHistory CreateNewChatHistory()
    {
        return new ChatHistory();
    }

    public async Task<ChatMessageContent> GetChatCompletionAsync(ChatHistory history, string? input)
    {
        if (!string.IsNullOrEmpty(input))
        {
            history.AddUserMessage(input);
        }

        _logger.LogDebug("Recieved message '{Message}'", input);

        _logger.LogDebug("Sending chat completion request with history containing {MessageCount} messages", history.Count);
        
        var result = await _chatCompletionService.GetChatMessageContentAsync(
            history,
            kernel: _kernel);

        history.AddMessage(result.Role, result.Content ?? string.Empty);
        
        _logger.LogDebug("Recieved chat completion response with content '{Content}'", result.Content);

        return result;
    }
}
