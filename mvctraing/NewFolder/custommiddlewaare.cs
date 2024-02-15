namespace mvctraing.NewFolder
{
    public class custommiddlewaare
    { 

        public custommiddlewaare(RequestDelegate next,ILogger<custommiddlewaare> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);
        }
    }
}
