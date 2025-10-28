[AuthorizeAdmin]
[Area("Admin")]
public class HelloWorldController : BasePluginController
{
    private readonly IHelloWorldService _helloWorldService;

    public HelloWorldController(IHelloWorldService helloWorldService)
    {
        _helloWorldService = helloWorldService;
    }

    public IActionResult Index()
    {
        ViewBag.Message = _helloWorldService.GetMessage();
        return View("~/Plugins/Nop.Plugin.Misc.HelloWorld/Views/HelloWorld/Index.cshtml");
    }
}
