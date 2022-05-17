using AutoMapper;
using BaseEcommerce.Business.Abstract;
using BaseEcommerce.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace BaseEcommerce.WebUI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly RoleManager<IdentityRole> _roleManager;
        public HomeController(ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager, IProductService productService, IMapper mapper)
        {
            _logger = logger;
            _productService = productService; 
            _mapper = mapper;   
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            ViewBag.roleList = new SelectList(roles, "Id", "Name");
            return View();
        }

      
        public PartialViewResult GetProductList(string role)
        {
            ViewBag.Value = role;
            var roles = _roleManager.Roles.ToList();
            ViewBag.roleList = new SelectList(roles, "Id", "Name");
            var products = _productService.GetAllProduct();
            return PartialView("Partial/_ProductList",_mapper.Map<List<ProductViewModel>>(products));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}