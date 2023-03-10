using Microsoft.CodeAnalysis;

namespace DotnetDispatcher.Generator;

internal record DispatcherGenerationMetadata(string Namespace, string DispatcherName, INamedTypeSymbol QuerySymbol, INamedTypeSymbol? ResponseSymbol, CqrsType CqrsType, INamedTypeSymbol? QueryHandler = null)
{
    public INamedTypeSymbol QuerySymbol { get; } = QuerySymbol;
    public INamedTypeSymbol? ResponseSymbol { get; } = ResponseSymbol;
    public string Namespace { get; } = Namespace;
    public string DispatcherName { get; } = DispatcherName;
    public CqrsType CqrsType { get; } = CqrsType;
    public INamedTypeSymbol? QueryHandler { get; } = QueryHandler;
}

internal enum CqrsType
{
    Query,
    Command
}