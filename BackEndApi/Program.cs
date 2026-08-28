using BackEndApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.Configure<OpenAiOptions>(builder.Configuration.GetSection(OpenAiOptions.SectionName));
builder.Services.AddHttpClient<OpenAiLlmClient>(client =>
{
    client.BaseAddress = new Uri("https://api.openai.com/v1/");
    client.Timeout = TimeSpan.FromMinutes(2);
});
builder.Services.AddHttpClient<OpenAiEmbeddingClient>(client =>
{
    client.BaseAddress = new Uri("https://api.openai.com/v1/");
    client.Timeout = TimeSpan.FromMinutes(2);
});
builder.Services.AddTransient<ILlmClient>(sp => sp.GetRequiredService<OpenAiLlmClient>());
builder.Services.AddTransient<IEmbeddingClient>(sp => sp.GetRequiredService<OpenAiEmbeddingClient>());
builder.Services.AddSingleton<IContextRetriever, EmbeddingContextRetriever>();
builder.Services.AddSingleton<IKnowledgeBaseWriter, KnowledgeBaseWriter>();
builder.Services.AddSingleton<IDocumentTextExtractor, DocumentTextExtractor>();
builder.Services.AddScoped<IAiService, AiService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();
app.Run();
