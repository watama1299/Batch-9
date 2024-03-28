using Microsoft.AspNetCore.Mvc;

namespace Web_API;

/**
    USE A PARENT CLASS TO ROUTE ALL CHILD CLASS TO A CERTAIN ROUTING
    INSTEAD OF CHANGING THE ROUTING ONE BY ONE IN EACH CLASS
*/
[Route("/apis/[controller]")]
public class APIBaseController : ControllerBase
{
}
