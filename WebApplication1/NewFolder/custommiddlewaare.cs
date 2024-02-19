namespace mvctraing.NewFolder
{
    public class Custommiddlewaare
    {
        private RequestDelegate _next;
        private ILogger<Custommiddlewaare> _logger;

        public Custommiddlewaare(RequestDelegate next, ILogger<Custommiddlewaare> logger)
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
