using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

namespace SematicKernelOllama.Services;

public interface IChatService
{
    Task<ChatMessageContent> GetChatCompletionAsync(ChatHistory history, string? input);
    ChatHistory CreateNewChatHistory();
}
